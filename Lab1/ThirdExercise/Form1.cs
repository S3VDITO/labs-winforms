using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using GraphicsPath path = new GraphicsPath();
            path.AddPolygon(new PointF[]
                {
                    new PointF(0, 0),
                    new PointF(512, 0),
                    new PointF(256, 512),
                });
            Region = new Region(path);
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
