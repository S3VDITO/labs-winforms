using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            OpenNewFormButton.Left = (ClientSize.Width - OpenNewFormButton.Width) / 2;
            OpenNewFormButton.Top = (ClientSize.Height - OpenNewFormButton.Height) / 2;
        }

        private void OpenNewFormButton_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }
    }
}
