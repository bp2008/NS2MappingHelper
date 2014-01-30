using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NS2MappingHelper
{
	public partial class Configuration : Form
	{
		NS2Mod currentMod;
		public Configuration(NS2Mod currentMod)
		{
			this.currentMod = currentMod;
			InitializeComponent();

			cbUseBuilder.Checked = Program.cfg.useBuilder;
			cbReverseOrder.Checked = currentMod.overlayReverseOrder;
			txtNs2Dir.Text = Program.cfg.ns2Path;

			if (!string.IsNullOrWhiteSpace(currentMod.overviewOverlayPath))
			{
				txtOverlayPath.Text = currentMod.overviewOverlayPath;
				FileInfo fi = new FileInfo(currentMod.overviewOverlayPath);
				if (fi.Exists && fi.Length > 0)
				{
					try
					{
						Bitmap bmp = (Bitmap)Bitmap.FromFile(fi.FullName);
						pictureBox1.Image = bmp;
					}
					catch (Exception) { }
				}
			}
		}

		private void btnBrowseNS2Dir_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				DirectoryInfo ns2Dir = new DirectoryInfo(folderBrowserDialog2.SelectedPath);
				if (ns2Dir.Name.ToLower() == "ns2" && ns2Dir.Parent.Name.ToLower() == "natural selection 2")
					ns2Dir = ns2Dir.Parent;
				txtNs2Dir.Text = ns2Dir.FullName;
			}
		}

		private void btnBrowseOverlayFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				txtOverlayPath.Text = openFileDialog1.FileName;
		}

		private void txtOverlayPath_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtOverlayPath.Text))
			{
				FileInfo fi = new FileInfo(txtOverlayPath.Text);
				if (fi.Exists && fi.Length > 0)
				{
					try
					{
						Bitmap bmp = (Bitmap)Bitmap.FromFile(fi.FullName);
						pictureBox1.Image = bmp;
					}
					catch (Exception) { }
				}
				currentMod.overviewOverlayPath = fi.FullName;
			}
			else
				currentMod.overviewOverlayPath = txtOverlayPath.Text;
			Program.cfg.Save(Globals.ConfigFilePath);
		}

		private void cbUseBuilder_CheckedChanged(object sender, EventArgs e)
		{
			Program.cfg.useBuilder = cbUseBuilder.Checked;
			Program.cfg.Save(Globals.ConfigFilePath);
		}

		private void cbReverseOrder_CheckedChanged(object sender, EventArgs e)
		{
			currentMod.overlayReverseOrder = cbReverseOrder.Checked;
			Program.cfg.Save(Globals.ConfigFilePath);
		}

		private void txtNs2Dir_TextChanged(object sender, EventArgs e)
		{
			Program.cfg.ns2Path = txtNs2Dir.Text;
			Program.cfg.Save(Globals.ConfigFilePath);
		}
	}
}
