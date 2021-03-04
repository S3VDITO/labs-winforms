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

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using GraphicsPath path = new GraphicsPath();
            path.AddPolygon(new Point[]
            {
                new Point(0, 256),
                new Point(256, 0),
                new Point(512, 256),
                new Point(256, 512),
            });
            Region = new Region(path);

            CloseButton.Left = (ClientSize.Width - CloseButton.Width) / 2;
            CloseButton.Top = (ClientSize.Height - CloseButton.Height) / 2;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
