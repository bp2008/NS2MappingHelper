using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using ImageMagick;

namespace NS2MappingHelper
{
	public partial class Main : Form
	{
		NS2Mod currentMod = null;
		BackgroundWorker overviewManager;
		StartupOperation startupOperation = StartupOperation.None;
		string arg0;

		public Main(string[] args)
		{
			overviewManager = new BackgroundWorker();
			overviewManager.DoWork += new DoWorkEventHandler(overviewManager_DoWork);
			overviewManager.RunWorkerCompleted += new RunWorkerCompletedEventHandler(overviewManager_RunWorkerCompleted);
			overviewManager.WorkerReportsProgress = false;
			overviewManager.WorkerSupportsCancellation = true;

			InitializeComponent();

			PopulateRecentMenu();

			if (args.Length > 0)
			{
				arg0 = args[0];
				if (args.Length == 1)
					startupOperation = StartupOperation.RestartWithGUI;
				if (args.Length == 2)
				{
					string opt = args[1].ToLower();
					if (opt == "overview")
						startupOperation = StartupOperation.Overview;
					else if (opt == "overviewlaunch")
						startupOperation = StartupOperation.OverviewLaunch;
					else if (opt == "launch")
						startupOperation = StartupOperation.Launch;
					else if (opt != "loadgui")
						startupOperation = StartupOperation.RestartWithGUI;
				}
				OpenMod(arg0);
			}
			if (currentMod == null)
			{
				foreach (NS2Mod mod in Program.cfg.mods)
				{
					if (mod.modDir == Program.cfg.lastOpenMod)
					{
						currentMod = mod;
						currentMod.lastOpened = DateTime.Now;
						break;
					}
				}
				if (currentMod == null)
				{
					currentMod = new NS2Mod();
					Program.cfg.mods.Add(currentMod);
					currentMod.lastOpened = DateTime.Now;
					Program.cfg.lastOpenMod = currentMod.modDir;
				}
				Program.cfg.Save(Globals.ConfigFilePath);
				LoadExistingOverviewImageIntoGUI();
			}

			btnCopyToOutput.Visible = btnCopyToOutput.Enabled = !Program.cfg.useBuilder;
			txtModDir.Text = currentMod.modDir;
		}

		private void PopulateRecentMenu()
		{
			Program.cfg.mods.Sort(new ComparisonComparer<NS2Mod>((m1, m2) =>
			{
				return m2.lastOpened.CompareTo(m1.lastOpened);
			}));

			recentToolStripMenuItem.DropDownItems.Clear();
			foreach (NS2Mod mod in Program.cfg.mods)
			{
				if (!string.IsNullOrWhiteSpace(mod.modDir))
				{
					DirectoryInfo di = new DirectoryInfo(mod.modDir);
					if (di.Exists)
					{
						ToolStripItem tsi = recentToolStripMenuItem.DropDownItems.Add(di.Name);
						tsi.Click += new EventHandler(recentItemToolStripMenuItem_Click);
						tsi.Tag = mod.modDir;
					}
				}
			}
		}

		private bool OpenMod(string path, bool bSilent = false)
		{
			DirectoryInfo di = new DirectoryInfo(path);
			if (di.Exists && di.Name.ToLower() == "mapsrc" && di.Parent != null && di.Parent.Name.ToLower() == "source")
				di = di.Parent;
			if (di.Exists && di.Name.ToLower() == "source" && di.Parent != null)
			{
				FileInfo[] files = di.Parent.GetFiles("*.settings");
				if (files.Length > 0 && files[0].Name == "mod.settings")
					di = di.Parent;
			}
			if (di.Exists && File.Exists(di.FullName.TrimEnd('\\', '/') + "/mod.settings"))
			{
				bool loadedMod = false;
				string modDir = di.FullName;
				foreach (NS2Mod mod in Program.cfg.mods)
				{
					if (mod.modDir == modDir)
					{
						loadedMod = true;
						currentMod = mod;
						break;
					}
				}
				if (!loadedMod)
				{
					loadedMod = true;
					currentMod = new NS2Mod();
					currentMod.modDir = modDir;
					Program.cfg.mods.Add(currentMod);
				}
				Program.cfg.lastOpenMod = currentMod.modDir;
				currentMod.lastOpened = DateTime.Now;
				Program.cfg.Save(Globals.ConfigFilePath);
				LoadExistingOverviewImageIntoGUI();
				return true;
			}
			else if (!bSilent)
				MessageBox.Show(di.FullName + Environment.NewLine + Environment.NewLine + " is not an NS2 Mod directory!");
			return false;
		}

		private void LoadExistingOverviewImageIntoGUI()
		{
			try
			{
				DirectoryInfo di = new DirectoryInfo(currentMod.modDir.TrimEnd('\\', '/') + "/source/mapsrc/overviews/");
				FileInfo[] overviews = di.GetFiles("*.tga");
				if (overviews.Length > 0)
				{
					MagickImage mi = new MagickImage(overviews[0].FullName);
					pictureMap.Image = mi.ToBitmap();
				}
			}
			catch (Exception ex)
			{
				Logger.Debug(ex);
			}
		}

		#region Trivial Button Clicks
		private void recentItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string modPath = (string)((ToolStripItem)sender).Tag;
			txtModDir.Text = modPath;
		}
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AboutBox1().ShowDialog();
		}

		private void modConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Configuration(currentMod).ShowDialog();
			btnCopyToOutput.Visible = btnCopyToOutput.Enabled = !Program.cfg.useBuilder;
		}

		private void btnBrowseModDir_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				DirectoryInfo modDir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
				txtModDir.Text = modDir.FullName;
			}
		}
		#endregion

		#region Colored Button Clicks

		#region Overview
		private void btnCreateOverview_Click(object sender, EventArgs e)
		{
			CreateOverview();
		}

		private void CreateOverview(bool isPartOfLaunchProcedure = false)
		{
			lblStatus.Text = "Creating Overview";
			// Disable Controls
			foreach (Control c in this.Controls)
			{
				Type t = c.GetType();
				if (t == typeof(Button) || t == typeof(TextBox) || t == typeof(PictureBox))
				{
					c.Tag = c.Enabled;
					c.Enabled = false;
				}
			}
			foreach (ToolStripItem c in menuStrip1.Items)
			{
				c.Tag = c.Enabled;
				c.Enabled = false;
			}
			overviewManager.RunWorkerAsync(isPartOfLaunchProcedure);
		}

		void overviewManager_DoWork(object sender, DoWorkEventArgs e)
		{
			e.Result = e.Argument;

			// Locate Overview.exe
			FileInfo overviewExe = new FileInfo(Program.cfg.ns2Path.TrimEnd('\\', '/') + "/Overview.exe");
			if (!overviewExe.Exists)
				return;

			// Locate .level
			FileInfo level = GetLevelFile();
			if (level == null)
				return;

			ProcessStartInfo psi = new ProcessStartInfo(overviewExe.FullName, "\"" + level.FullName + "\" \"" + Globals.ApplicationDirectoryBase + "overviews/" + level.Name.Substring(0, level.Name.Length - level.Extension.Length) + "\"");
			psi.WorkingDirectory = Program.cfg.ns2Path;
			Process p = Process.Start(psi);
			while (!p.HasExited)
			{
				if (overviewManager.CancellationPending)
				{
					p.Kill();
					break;
				}
				Thread.Sleep(100);
			}
		}

		void overviewManager_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			BlendOverlayImageIntoOverview();
			CopyOverviewToMapsrc();
			LoadExistingOverviewImageIntoGUI();
			// Re-enable Controls
			foreach (Control c in this.Controls)
			{
				Type t = c.GetType();
				if (t == typeof(Button) || t == typeof(TextBox) || t == typeof(PictureBox) || t == typeof(ToolStripMenuItem))
					c.Enabled = (bool)c.Tag;
			}
			foreach (ToolStripItem c in menuStrip1.Items)
			{
				c.Enabled = (bool)c.Tag;
			}
			lblStatus.Text = "Creating Overview ... DONE";
			if ((bool)e.Result)
				Launch(false);
			else
			{
				if (startupOperation != StartupOperation.None)
					this.Close();
			}
		}

		private void BlendOverlayImageIntoOverview()
		{
			// Locate the overlay and overview images
			FileInfo overlay = GetOverlayFileForCurrentMod();
			if (overlay == null)
				return;
			FileInfo overview = GetCurrentModCachedOverviewFile();
			if (overview == null)
				return;

			// Load the overlay and overview images
			MagickImage miOverlay = new MagickImage(overlay.FullName);
			if (miOverlay.Width <= 0 || miOverlay.Height <= 0)
				return;
			MagickImage miOverview = new MagickImage(overview.FullName);
			if (miOverview.Width <= 0 || miOverview.Height <= 0)
				return;
			if (miOverlay.Width != miOverview.Width || miOverlay.Height != miOverview.Height)
			{
				MagickGeometry mg = new MagickGeometry(miOverview.Width, miOverview.Height);
				mg.IgnoreAspectRatio = true;
				miOverlay.Resize(mg);
			}
			// Blend the overlay with the overview.
			miOverlay.Composite(miOverview, Gravity.Northwest, currentMod.overlayReverseOrder ? CompositeOperator.SrcOver : CompositeOperator.DstOver);
			using (FileStream fsImageOut = new FileStream(overview.FullName, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
			{
				miOverlay.Write(fsImageOut);
			}
		}

		private void CopyOverviewToMapsrc()
		{
			DirectoryInfo overviewCache = GetOverviewCacheDirectoryForCurrentMod();
			if (overviewCache == null)
				return;
			DirectoryInfo overviews = GetOverviewsSourceDirectory();
			if (overviews == null)
				return;
			RecursiveDirectoryCopy(overviewCache, overviews);
		}

		#region Overview/Overlay Management Helpers
		private FileInfo GetOverlayFileForCurrentMod()
		{
			if (!string.IsNullOrWhiteSpace(currentMod.overviewOverlayPath))
			{
				FileInfo overlay = new FileInfo(currentMod.overviewOverlayPath);
				if (overlay.Exists)
					return overlay;
			}
			return null;
		}
		private FileInfo GetCurrentModCachedOverviewFile()
		{
			DirectoryInfo diOverviewCache = GetOverviewCacheDirectoryForCurrentMod();
			if (diOverviewCache == null)
				return null;
			FileInfo[] overviewFile = diOverviewCache.GetFiles("*.tga");
			if (overviewFile.Length < 1 || !overviewFile[0].Exists)
				return null;
			return overviewFile[0];
		}
		private DirectoryInfo GetOverviewCacheDirectoryForCurrentMod()
		{
			FileInfo level = GetLevelFile();
			if (level == null)
				return null;
			DirectoryInfo diOverviewCache = new DirectoryInfo(Globals.ApplicationDirectoryBase + "overviews/" + level.Name.Substring(0, level.Name.Length - level.Extension.Length) + "/maps/overviews/");
			if (!diOverviewCache.Exists)
				return null;
			return diOverviewCache;
		}
		private FileInfo GetLevelFile()
		{
			DirectoryInfo diMapsrc = GetMapsrcDirectory();
			if (diMapsrc == null)
				return null;
			FileInfo[] level = diMapsrc.GetFiles("*.level");
			if (level.Length < 1 || !level[0].Exists)
				return null;
			return level[0];
		}
		private DirectoryInfo GetMapsrcDirectory()
		{
			DirectoryInfo diMapsrc = new DirectoryInfo(currentMod.modDir.TrimEnd('\\', '/') + "/source/mapsrc");
			if (!diMapsrc.Exists)
				return null;
			return diMapsrc;
		}
		private DirectoryInfo GetOverviewsSourceDirectory()
		{
			DirectoryInfo diMapsrc = GetMapsrcDirectory();
			if (!diMapsrc.Exists)
				return null;
			DirectoryInfo diOverviews = new DirectoryInfo(diMapsrc.FullName.TrimEnd('\\', '/') + "/overviews");
			if (!diOverviews.Exists)
				Directory.CreateDirectory(diOverviews.FullName);
			return diOverviews;
		}
		#endregion

		#endregion

		private void btnCopyToOutput_Click(object sender, EventArgs e)
		{
			CopyToOutput();
		}

		private void CopyToOutput()
		{
			if (!Program.cfg.useBuilder)
			{
				lblStatus.Text = "Copying source -> output";
				string sourceDirBase = currentMod.modDir.TrimEnd('\\', '/') + "/source/";
				string targetDirBase = currentMod.modDir.TrimEnd('\\', '/') + "/output/";
				// source, target, source, target, source, target, etc... 
				string[] folderMappings = new string[]
				{
					"lua","lua",
					"mapsrc","maps",
					"materialsrc","materials",
					"modelsrc","models",
					"soundsrc","sound"
				};
				for (int i = 0; i + 1 < folderMappings.Length; i += 2)
					RecursiveDirectoryCopy(new DirectoryInfo(sourceDirBase + folderMappings[i]), new DirectoryInfo(targetDirBase + folderMappings[i + 1]));
				lblStatus.Text = "Copying source -> output ... DONE";
			}
		}
		private void btnCopyToNS2_Click(object sender, EventArgs e)
		{
			CopyToNs2();
		}
		private void CopyToNs2()
		{
			lblStatus.Text = "Copying output -> ns2";
			DirectoryInfo modDir = new DirectoryInfo(currentMod.modDir);
			if (!modDir.Exists)
			{
				MessageBox.Show("Could not find mod directory at " + modDir.FullName);
				return;
			}
			DirectoryInfo ns2Dir = new DirectoryInfo(Program.cfg.ns2Path);
			if (!ns2Dir.Exists)
			{
				MessageBox.Show("\"Natural Selection 2\" directory does not exist!");
				return;
			}
			DirectoryInfo source = new DirectoryInfo(currentMod.modDir.TrimEnd('\\', '/') + "/output/");
			DirectoryInfo target = new DirectoryInfo(Program.cfg.ns2Path.TrimEnd('\\', '/') + "/" + modDir.Name + "/");
			RecursiveDirectoryCopy(source, target);
			lblStatus.Text = "Copying output -> ns2 ... DONE";
		}

		private void btnJustLaunch_Click(object sender, EventArgs e)
		{
			JustLaunch();
		}

		private void JustLaunch()
		{
			lblStatus.Text = "Launching NS2";
			DirectoryInfo modDir = new DirectoryInfo(currentMod.modDir);
			if (!modDir.Exists)
				return;
			FileInfo ns2exe = new FileInfo(Program.cfg.ns2Path.TrimEnd('\\', '/') + "/NS2.exe");
			if (!ns2exe.Exists)
				return;
			ProcessStartInfo psi = new ProcessStartInfo(ns2exe.FullName, "-game \"" + modDir.Name + "\" -hotload");
			psi.UseShellExecute = false;
			psi.WorkingDirectory = Program.cfg.ns2Path;
			Process.Start(psi);
			lblStatus.Text = "Launching NS2 ... DONE";
		}

		private void btnFullLaunch_Click(object sender, EventArgs e)
		{
			Launch(true);
		}

		private void btnQuickLaunch_Click(object sender, EventArgs e)
		{
			Launch(false);
		}

		private void Launch(bool overviewFirst = false)
		{
			if (overviewFirst)
				CreateOverview(true);
			else
			{
				CopyToOutput();
				CopyToNs2();
				JustLaunch();
				if (startupOperation != StartupOperation.None)
					this.Close();
			}
		}

		#endregion
		#region Helpers
		private void RecursiveDirectoryCopy(DirectoryInfo source, DirectoryInfo target)
		{
			if (!source.Exists || source.GetFileSystemInfos().Length == 0)
				return;
			if (!target.Exists)
				Directory.CreateDirectory(target.FullName);
			string targetBaseDir = target.FullName.TrimEnd('\\', '/') + "/";
			// Copy Files
			FileInfo[] files = source.GetFiles();
			foreach (FileInfo fi in files)
			{
				fi.CopyTo(targetBaseDir + fi.Name, true);
			}
			// Copy Subdirectories
			DirectoryInfo[] subdirs = source.GetDirectories();
			foreach (DirectoryInfo di in subdirs)
				RecursiveDirectoryCopy(di, new DirectoryInfo(targetBaseDir + di.Name));
		}
		#endregion

		private void txtModDir_TextChanged(object sender, EventArgs e)
		{
			OpenMod(txtModDir.Text, true);
			PopulateRecentMenu();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (overviewManager.IsBusy)
				overviewManager.CancelAsync();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			bool initialSetupDone = !string.IsNullOrWhiteSpace(Program.cfg.ns2Path) && Directory.Exists(Program.cfg.ns2Path);
			switch (startupOperation)
			{
				case StartupOperation.Overview:
					if (!initialSetupDone)
					{
						Console.WriteLine("Please start NS2MappingHelper.exe from outside the Spark Editor and configure the global advanced settings.");
						this.Close();
					}
					else
					{
						Console.WriteLine("Creating Overview");
						CreateOverview(false);
					}
					return;
				case StartupOperation.Launch:
					if (!initialSetupDone)
					{
						Console.WriteLine("Please start NS2MappingHelper.exe from outside the Spark Editor and configure the global advanced settings.");
						this.Close();
					}
					else
					{
						Console.WriteLine("Launching NS2");
						Launch(false);
					}
					return;
				case StartupOperation.OverviewLaunch:
					if (!initialSetupDone)
					{
						Console.WriteLine("Please start NS2MappingHelper.exe from outside the Spark Editor and configure the global advanced settings.");
						this.Close();
					}
					else
					{
						Console.WriteLine("Creating Overview, then launching NS2");
						Launch(true);
					}
					return;
				case StartupOperation.RestartWithGUI:
					Console.WriteLine("Starting GUI");
					StartWithGUI(arg0);
					this.Close();
					return;
				case StartupOperation.Exit:
					Console.WriteLine("Usage: NS2MappingHelper.exe \"$(ItemDir)\" [overview|launch|overviewlaunch]");
					this.Close();
					return;
				case StartupOperation.None:
					if (!initialSetupDone)
						new Configuration(currentMod).ShowDialog();
					return;
				default:
					Logger.Debug("No handler for StartupOperation " + startupOperation.ToString());
					this.Close();
					return;
			}
		}

		private static void StartWithGUI(string arg)
		{
			ProcessStartInfo psi = new ProcessStartInfo(Globals.ExecutablePath, "\"" + arg + "\" loadgui");
			psi.UseShellExecute = false;
			Process.Start(psi);
		}
	}
}
