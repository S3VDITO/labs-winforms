using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(new Point(0, 0), Size));

            Region = new Region(path);
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
