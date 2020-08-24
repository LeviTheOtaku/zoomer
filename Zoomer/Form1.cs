using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void screenshotTimer_Tick(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - 50;
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - 50;
            int w = 100;
            int h = 100;
            Size s = new Size(100, 100);

            Rectangle rect = new Rectangle(x, y, w, h);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, s, CopyPixelOperation.SourceCopy);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                screenshotTimer.Enabled = !screenshotTimer.Enabled;
        }
    }
}
