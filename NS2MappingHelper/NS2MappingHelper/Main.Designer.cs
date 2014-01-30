namespace NS2MappingHelper
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label3 = new System.Windows.Forms.Label();
			this.txtModDir = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnCreateOverview = new System.Windows.Forms.Button();
			this.btnCopyToOutput = new System.Windows.Forms.Button();
			this.btnJustLaunch = new System.Windows.Forms.Button();
			this.btnQuickLaunch = new System.Windows.Forms.Button();
			this.btnFullLaunch = new System.Windows.Forms.Button();
			this.btnCopyToNS2 = new System.Windows.Forms.Button();
			this.pictureMap = new System.Windows.Forms.PictureBox();
			this.btnBrowseModDir = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureMap)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(18, 51);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mod Dir:";
			// 
			// txtModDir
			// 
			this.txtModDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtModDir.Location = new System.Drawing.Point(105, 46);
			this.txtModDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtModDir.Name = "txtModDir";
			this.txtModDir.Size = new System.Drawing.Size(301, 26);
			this.txtModDir.TabIndex = 3;
			this.toolTip1.SetToolTip(this.txtModDir, "The directory containg the source and output directories for your mod.");
			this.txtModDir.TextChanged += new System.EventHandler(this.txtModDir_TextChanged);
			// 
			// btnCreateOverview
			// 
			this.btnCreateOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCreateOverview.Location = new System.Drawing.Point(18, 86);
			this.btnCreateOverview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCreateOverview.Name = "btnCreateOverview";
			this.btnCreateOverview.Size = new System.Drawing.Size(208, 54);
			this.btnCreateOverview.TabIndex = 8;
			this.btnCreateOverview.Text = "Create Overview";
			this.toolTip1.SetToolTip(this.btnCreateOverview, "Generates the overview of your map.");
			this.btnCreateOverview.UseVisualStyleBackColor = false;
			this.btnCreateOverview.Click += new System.EventHandler(this.btnCreateOverview_Click);
			// 
			// btnCopyToOutput
			// 
			this.btnCopyToOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCopyToOutput.Location = new System.Drawing.Point(18, 148);
			this.btnCopyToOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCopyToOutput.Name = "btnCopyToOutput";
			this.btnCopyToOutput.Size = new System.Drawing.Size(208, 54);
			this.btnCopyToOutput.TabIndex = 9;
			this.btnCopyToOutput.Text = "Source -> Output";
			this.toolTip1.SetToolTip(this.btnCopyToOutput, "Copies the files in your mod\'s source directory to the output directory.\r\n\r\nThis " +
        "should only be used if you aren\'t running Builder.");
			this.btnCopyToOutput.UseVisualStyleBackColor = false;
			this.btnCopyToOutput.Click += new System.EventHandler(this.btnCopyToOutput_Click);
			// 
			// btnJustLaunch
			// 
			this.btnJustLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnJustLaunch.Location = new System.Drawing.Point(18, 274);
			this.btnJustLaunch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnJustLaunch.Name = "btnJustLaunch";
			this.btnJustLaunch.Size = new System.Drawing.Size(208, 54);
			this.btnJustLaunch.TabIndex = 11;
			this.btnJustLaunch.Text = "Launch NS2";
			this.toolTip1.SetToolTip(this.btnJustLaunch, "Launches Natural Selection 2 with the command:\r\n\r\nns2.exe -game \"mod_name\" -hotlo" +
        "ad");
			this.btnJustLaunch.UseVisualStyleBackColor = false;
			this.btnJustLaunch.Click += new System.EventHandler(this.btnJustLaunch_Click);
			// 
			// btnQuickLaunch
			// 
			this.btnQuickLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnQuickLaunch.Location = new System.Drawing.Point(236, 212);
			this.btnQuickLaunch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnQuickLaunch.Name = "btnQuickLaunch";
			this.btnQuickLaunch.Size = new System.Drawing.Size(208, 117);
			this.btnQuickLaunch.TabIndex = 13;
			this.btnQuickLaunch.Text = "Quick Launch";
			this.toolTip1.SetToolTip(this.btnQuickLaunch, "Copies all necessary files and Launches Natural Selection 2.\r\nSame as clicking al" +
        "l the green buttons from the left column in sequence.");
			this.btnQuickLaunch.UseVisualStyleBackColor = false;
			this.btnQuickLaunch.Click += new System.EventHandler(this.btnQuickLaunch_Click);
			// 
			// btnFullLaunch
			// 
			this.btnFullLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnFullLaunch.Location = new System.Drawing.Point(236, 86);
			this.btnFullLaunch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnFullLaunch.Name = "btnFullLaunch";
			this.btnFullLaunch.Size = new System.Drawing.Size(208, 117);
			this.btnFullLaunch.TabIndex = 14;
			this.btnFullLaunch.Text = "Overview + Launch";
			this.toolTip1.SetToolTip(this.btnFullLaunch, "Creates the overview image, copies necessary files, and launches Natural Selectio" +
        "n 2.\r\nSame as clicking all the buttons in the left column.");
			this.btnFullLaunch.UseVisualStyleBackColor = false;
			this.btnFullLaunch.Click += new System.EventHandler(this.btnFullLaunch_Click);
			// 
			// btnCopyToNS2
			// 
			this.btnCopyToNS2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCopyToNS2.Location = new System.Drawing.Point(18, 212);
			this.btnCopyToNS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCopyToNS2.Name = "btnCopyToNS2";
			this.btnCopyToNS2.Size = new System.Drawing.Size(208, 54);
			this.btnCopyToNS2.TabIndex = 10;
			this.btnCopyToNS2.Text = "Output -> NS2";
			this.toolTip1.SetToolTip(this.btnCopyToNS2, "Copies the files in your mod\'s output directory to the \r\n.../Natural Selection 2/" +
        "mod_name/\r\ndirectory so you can test the map.");
			this.btnCopyToNS2.UseVisualStyleBackColor = false;
			this.btnCopyToNS2.Click += new System.EventHandler(this.btnCopyToNS2_Click);
			// 
			// pictureMap
			// 
			this.pictureMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureMap.Location = new System.Drawing.Point(22, 338);
			this.pictureMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureMap.Name = "pictureMap";
			this.pictureMap.Size = new System.Drawing.Size(422, 422);
			this.pictureMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureMap.TabIndex = 15;
			this.pictureMap.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureMap, "Your map\'s overview image.");
			// 
			// btnBrowseModDir
			// 
			this.btnBrowseModDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseModDir.BackgroundImage = global::NS2MappingHelper.Properties.Resources._200px_Magnifying_glass_icon_svg;
			this.btnBrowseModDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBrowseModDir.Location = new System.Drawing.Point(417, 44);
			this.btnBrowseModDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBrowseModDir.Name = "btnBrowseModDir";
			this.btnBrowseModDir.Size = new System.Drawing.Size(33, 33);
			this.btnBrowseModDir.TabIndex = 6;
			this.toolTip1.SetToolTip(this.btnBrowseModDir, "Browse for the mod directory.");
			this.btnBrowseModDir.UseVisualStyleBackColor = true;
			this.btnBrowseModDir.Click += new System.EventHandler(this.btnBrowseModDir_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 778);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
			this.statusStrip1.Size = new System.Drawing.Size(462, 22);
			this.statusStrip1.TabIndex = 12;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 17);
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(462, 35);
			this.menuStrip1.TabIndex = 16;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// recentToolStripMenuItem
			// 
			this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
			this.recentToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
			this.recentToolStripMenuItem.Text = "Recent";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modConfigurationToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// modConfigurationToolStripMenuItem
			// 
			this.modConfigurationToolStripMenuItem.Name = "modConfigurationToolStripMenuItem";
			this.modConfigurationToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
			this.modConfigurationToolStripMenuItem.Text = "Advanced Configuration";
			this.modConfigurationToolStripMenuItem.Click += new System.EventHandler(this.modConfigurationToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 30);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.Description = "Locate Mod Directory";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(462, 800);
			this.Controls.Add(this.pictureMap);
			this.Controls.Add(this.btnFullLaunch);
			this.Controls.Add(this.btnQuickLaunch);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.btnJustLaunch);
			this.Controls.Add(this.btnCopyToNS2);
			this.Controls.Add(this.btnCopyToOutput);
			this.Controls.Add(this.btnCreateOverview);
			this.Controls.Add(this.btnBrowseModDir);
			this.Controls.Add(this.txtModDir);
			this.Controls.Add(this.label3);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Main";
			this.Text = "NS2 Mapping Helper";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureMap)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtModDir;
		private System.Windows.Forms.Button btnBrowseModDir;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnCreateOverview;
		private System.Windows.Forms.Button btnCopyToOutput;
		private System.Windows.Forms.Button btnJustLaunch;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.Button btnQuickLaunch;
		private System.Windows.Forms.Button btnFullLaunch;
		private System.Windows.Forms.Button btnCopyToNS2;
		private System.Windows.Forms.PictureBox pictureMap;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modConfigurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
	}
}

