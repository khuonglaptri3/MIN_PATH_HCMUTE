using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIN_PATH_HCMUTE
{
    public partial class Form1 : Form
    {
        private List<Point> points = new List<Point>();
        public Form1()
        {
            points.Add(button1.Location); 
            points.Add(button2.Location);   
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var point in points)
            {
                g.FillEllipse(Brushes.Red, point.X - 5, point.Y - 5, 10, 10);
            }
            if (points.Count > 1)
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    g.DrawLine(Pens.Blue, points[i], points[i + 1]);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
