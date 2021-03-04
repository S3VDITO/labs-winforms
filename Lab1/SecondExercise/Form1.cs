using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SecondExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using GraphicsPath myPath = new GraphicsPath();
            myPath.AddPolygon(new PointF[] 
            {
                new PointF(0, 0),
                new PointF(512, 0),
                new PointF(256, 256),
            });
            Region myRegion = new Region(myPath);
            Region = myRegion;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
