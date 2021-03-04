using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BorderStyle_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Resize_Click(object sender, EventArgs e)
        {
            Size = new Size(300, 500);
        }

        private void Opacity_Click(object sender, EventArgs e)
        {
            Opacity = 1;
        }
    }
}
