using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABGphysics
{
    public partial class _mainForm : Form
    {
        public _mainForm()
        {
            InitializeComponent();
        }

        private void панельУправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _menuControlPanel.Checked = !_menuControlPanel.Checked;
            _mainSplitContainer.Panel2Collapsed = !_mainSplitContainer.Panel2Collapsed;
        }

        private void _mainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            PrintRealCoord(e.X, e.Y, 1, 1, -1, -1);
        }

        private void PrintRealCoord(int x, int y, int maxX, int maxY, int minX,int minY)
        {
            double prcX = (100 * x) / _mainPictureBox.Width;
            double prcY = (100 * y) / _mainPictureBox.Height;

            int lengthX = Math.Abs(minX) + Math.Abs(maxX);
            int lengthY = Math.Abs(minY) + Math.Abs(maxY);

            double realX = (lengthX * prcX / 100) - Math.Abs(minX);
            double realY = (lengthY * prcY / 100) - Math.Abs(minY);

            richTextBox.Text = String.Format("(prcx: {0}, prcy: {1})\n(rx: {2}, ry: {3})\n(x: {4}, y: {5})", prcX, prcY, realX, realY, x, y);
        }
    }
}
