namespace NS2MappingHelper
{
	partial class Configuration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnBrowseNS2Dir = new System.Windows.Forms.Button();
			this.txtNs2Dir = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbUseBuilder = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbReverseOrder = new System.Windows.Forms.CheckBox();
			this.btnBrowseOverlayFile = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtOverlayPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnBrowseNS2Dir);
			this.groupBox1.Controls.Add(this.txtNs2Dir);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbUseBuilder);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(261, 90);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Global Configuration";
			// 
			// btnBrowseNS2Dir
			// 
			this.btnBrowseNS2Dir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseNS2Dir.BackgroundImage = global::NS2MappingHelper.Properties.Resources._200px_Magnifying_glass_icon_svg;
			this.btnBrowseNS2Dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBrowseNS2Dir.Location = new System.Drawing.Point(233, 57);
			this.btnBrowseNS2Dir.Name = "btnBrowseNS2Dir";
			this.btnBrowseNS2Dir.Size = new System.Drawing.Size(22, 22);
			this.btnBrowseNS2Dir.TabIndex = 10;
			this.toolTip1.SetToolTip(this.btnBrowseNS2Dir, "Browse for the Natural Selection 2 directory.");
			this.btnBrowseNS2Dir.UseVisualStyleBackColor = true;
			this.btnBrowseNS2Dir.Click += new System.EventHandler(this.btnBrowseNS2Dir_Click);
			// 
			// txtNs2Dir
			// 
			this.txtNs2Dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNs2Dir.Location = new System.Drawing.Point(6, 59);
			this.txtNs2Dir.Name = "txtNs2Dir";
			this.txtNs2Dir.Size = new System.Drawing.Size(221, 20);
			this.txtNs2Dir.TabIndex = 9;
			this.toolTip1.SetToolTip(this.txtNs2Dir, "The Natural Selection 2 directory, where LaunchPad.exe and NS2.exe are found.");
			this.txtNs2Dir.TextChanged += new System.EventHandler(this.txtNs2Dir_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Natural Selection 2 Directory:";
			// 
			// cbUseBuilder
			// 
			this.cbUseBuilder.AutoSize = true;
			this.cbUseBuilder.Checked = true;
			this.cbUseBuilder.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbUseBuilder.Location = new System.Drawing.Point(6, 22);
			this.cbUseBuilder.Name = "cbUseBuilder";
			this.cbUseBuilder.Size = new System.Drawing.Size(123, 17);
			this.cbUseBuilder.TabIndex = 2;
			this.cbUseBuilder.Text = "I use the Builder app";
			this.toolTip1.SetToolTip(this.cbUseBuilder, resources.GetString("cbUseBuilder.ToolTip"));
			this.cbUseBuilder.UseVisualStyleBackColor = true;
			this.cbUseBuilder.CheckedChanged += new System.EventHandler(this.cbUseBuilder_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.cbReverseOrder);
			this.groupBox2.Controls.Add(this.btnBrowseOverlayFile);
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Controls.Add(this.txtOverlayPath);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 108);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(261, 370);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Map Overlay (minimap) Configuration";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "For best results, use a 1024x1024 overlay image.";
			// 
			// cbReverseOrder
			// 
			this.cbReverseOrder.AutoSize = true;
			this.cbReverseOrder.Location = new System.Drawing.Point(11, 89);
			this.cbReverseOrder.Name = "cbReverseOrder";
			this.cbReverseOrder.Size = new System.Drawing.Size(238, 17);
			this.cbReverseOrder.TabIndex = 8;
			this.cbReverseOrder.Text = "Reverse order (draw overlay behind the map)";
			this.toolTip1.SetToolTip(this.cbReverseOrder, "If unchecked, the map will be put on top of this image.");
			this.cbReverseOrder.UseVisualStyleBackColor = true;
			this.cbReverseOrder.CheckedChanged += new System.EventHandler(this.cbReverseOrder_CheckedChanged);
			// 
			// btnBrowseOverlayFile
			// 
			this.btnBrowseOverlayFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseOverlayFile.BackgroundImage = global::NS2MappingHelper.Properties.Resources._200px_Magnifying_glass_icon_svg;
			this.btnBrowseOverlayFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBrowseOverlayFile.Location = new System.Drawing.Point(233, 41);
			this.btnBrowseOverlayFile.Name = "btnBrowseOverlayFile";
			this.btnBrowseOverlayFile.Size = new System.Drawing.Size(22, 22);
			this.btnBrowseOverlayFile.TabIndex = 7;
			this.toolTip1.SetToolTip(this.btnBrowseOverlayFile, "Browse for the image.");
			this.btnBrowseOverlayFile.UseVisualStyleBackColor = true;
			this.btnBrowseOverlayFile.Click += new System.EventHandler(this.btnBrowseOverlayFile_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(6, 115);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(249, 249);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox1, "pbOverlay");
			// 
			// txtOverlayPath
			// 
			this.txtOverlayPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOverlayPath.Location = new System.Drawing.Point(6, 43);
			this.txtOverlayPath.Name = "txtOverlayPath";
			this.txtOverlayPath.Size = new System.Drawing.Size(221, 20);
			this.txtOverlayPath.TabIndex = 2;
			this.txtOverlayPath.TextChanged += new System.EventHandler(this.txtOverlayPath_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Path to a .png file to overlay on the overview:";
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 60000;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "png";
			this.openFileDialog1.FileName = "overlay.png";
			this.openFileDialog1.Filter = "PNG files|*.png";
			this.openFileDialog1.Title = "Open overlay png file";
			// 
			// folderBrowserDialog2
			// 
			this.folderBrowserDialog2.Description = "Locate Natural Selection 2 Directory";
			// 
			// Configuration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 490);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Configuration";
			this.Text = "Advanced Configuration";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbUseBuilder;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox txtOverlayPath;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBrowseOverlayFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbReverseOrder;
		private System.Windows.Forms.Button btnBrowseNS2Dir;
		private System.Windows.Forms.TextBox txtNs2Dir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
	}
}