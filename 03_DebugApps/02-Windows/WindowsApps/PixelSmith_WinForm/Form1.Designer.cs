namespace PixelSmith_WinForm {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
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
		private void InitializeComponent() {
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.stretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showCrosshairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Image = global::PixelSmith_WinForm.Properties.Resources._135448730;
      this.pictureBox1.Location = new System.Drawing.Point(0, 28);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(792, 530);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
      this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(792, 28);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
      this.openToolStripMenuItem.Text = "Open";
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
      this.saveToolStripMenuItem.Text = "Save";
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.showCrosshairToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
      this.editToolStripMenuItem.Text = "Edit";
      // 
      // sizeToolStripMenuItem
      // 
      this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
      this.sizeToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
      this.sizeToolStripMenuItem.Text = "Size";
      this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
      // 
      // modeToolStripMenuItem
      // 
      this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.stretchToolStripMenuItem,
            this.centerToolStripMenuItem});
      this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
      this.modeToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
      this.modeToolStripMenuItem.Text = "Mode";
      // 
      // normalToolStripMenuItem
      // 
      this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
      this.normalToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
      this.normalToolStripMenuItem.Text = "Normal";
      this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
      // 
      // stretchToolStripMenuItem
      // 
      this.stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
      this.stretchToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
      this.stretchToolStripMenuItem.Text = "Stretch";
      this.stretchToolStripMenuItem.Click += new System.EventHandler(this.stretchToolStripMenuItem_Click);
      // 
      // centerToolStripMenuItem
      // 
      this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
      this.centerToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
      this.centerToolStripMenuItem.Text = "Center";
      this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
      // 
      // showCrosshairToolStripMenuItem
      // 
      this.showCrosshairToolStripMenuItem.Name = "showCrosshairToolStripMenuItem";
      this.showCrosshairToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
      this.showCrosshairToolStripMenuItem.Text = "Show Crosshair";
      this.showCrosshairToolStripMenuItem.Click += new System.EventHandler(this.showCrosshairToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(792, 558);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "PixelSmith (WinForms)";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stretchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showCrosshairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	}
}

