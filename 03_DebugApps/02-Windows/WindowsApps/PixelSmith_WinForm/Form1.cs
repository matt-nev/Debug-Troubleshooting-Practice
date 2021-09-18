using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelSmith_WinForm {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void sizeToolStripMenuItem_Click(object sender, EventArgs e) {

		}

		private void centerToolStripMenuItem_Click(object sender, EventArgs e) {
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
		}

		private void normalToolStripMenuItem_Click(object sender, EventArgs e) {
			pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
		}

		private void stretchToolStripMenuItem_Click(object sender, EventArgs e) {
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private Point _point = new Point();
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
			_point.X = e.X;
			_point.Y = e.Y;
			

			pictureBox1.Invalidate();
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e) {
			if (showCrosshairToolStripMenuItem.Checked == false)
			{
				return;
			}
			
			
			Graphics g = e.Graphics;


			// Draw a line in the PictureBox.
			g.DrawLine(pen: Pens.Yellow,
						x1: pictureBox1.Left,
						x2: pictureBox1.Right,
						y1: _point.Y,
						y2: _point.Y);
			g.DrawLine(pen: Pens.YellowGreen, 
								x1:	_point.X,
								x2: _point.X,
								y1: pictureBox1.Top,
								y2: pictureBox1.Bottom);
		}

		private void showCrosshairToolStripMenuItem_Click(object sender, EventArgs e) {
			this.showCrosshairToolStripMenuItem.Checked = !this.showCrosshairToolStripMenuItem.Checked;


		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			var form = new AboutBox();
			form.Show();
		}
	}
}
