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
        private Plane _plane;
        private Subjects.Сircle _a;

        public _mainForm()
        {
            InitializeComponent();

            _a = new Subjects.Сircle(new Coordinate(-50, -50), new Speed(50, new ABGphysics.Сharacteristics.Angle(135)));
            _plane = new Plane(new Coordinate(-100, -100), new Coordinate(100, 100));
            _a.Radius = 10;
            _plane.AddSubject(_a);
        }

        private void панельУправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _menuControlPanel.Checked = !_menuControlPanel.Checked;
            _mainSplitContainer.Panel2Collapsed = !_mainSplitContainer.Panel2Collapsed;
        }

        private void _mainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private Coordinate GetRealCoord(Coordinate coord, Plane plane, PictureBox pictureBox)
        {
            double prcX = (100 * (coord.X - _plane.MinCoordinate.X)) / plane.Width;
            double prcY = (100 * (coord.Y - _plane.MinCoordinate.Y)) / plane.Height;

            double realX = (pictureBox.Width * prcX / 100);
            double realY = (pictureBox.Height * prcY / 100);

            return new Coordinate(realX, realY);
        }

        private Coordinate GetRealCoordForPB(Coordinate coord, Plane plane, PictureBox pictureBox)
        {
            double prcX = (100 * coord.X) / pictureBox.Width;
            double prcY = (100 * coord.Y) / pictureBox.Height;

            double realX = ((plane.Width * prcX) / 100 + _plane.MinCoordinate.X);
            double realY = ((plane.Height * prcY)/ 100 + _plane.MinCoordinate.Y);

            return new Coordinate(realX, realY);
        }

        private void PrintCircle(Subjects.Сircle c)
        {
            System.Drawing.Graphics g = _mainPictureBox.CreateGraphics();
            Coordinate coord = GetRealCoord(c.Position, _plane, _mainPictureBox);
            g.DrawEllipse(new Pen(Color.Black), (int)coord.X - c.Radius, (int)coord.Y - c.Radius, (int)c.Radius * 2, (int)c.Radius * 2);
        }

        private void _mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void _mainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Coordinate coord = GetRealCoordForPB(new Coordinate(e.X, e.Y), _plane, _mainPictureBox);

            Subjects.Сircle temp = new Subjects.Сircle(coord, new Speed(50, new ABGphysics.Сharacteristics.Angle(135)));
            temp.Radius = 10;
            _plane.AddSubject(temp);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Graphics g = _mainPictureBox.CreateGraphics();
            g.Clear(Color.White);

            foreach(var subject in _plane.Subjects)
                PrintCircle((Subjects.Сircle)subject);

            _plane.Update(20);
        }
    }
}
