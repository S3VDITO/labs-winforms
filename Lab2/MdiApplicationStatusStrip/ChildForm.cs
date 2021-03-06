using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();

            ToggleMenuItem.Click += ToggleMenuItem_Click;
            FormatMenuItem.Click += FormatMenuItem_Click;
        }

        private void ToggleMenuItem_Click(object sender, EventArgs e)
        {
            if (ToggleMenuItem.Checked)
            {
                ToggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = Color.Black;
            }
            else
            {
                ToggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = Color.Blue;
            }
        }

        private void FormatMenuItem_Click(object sender, EventArgs e)
        {
            ChildTextBox.Font = new Font("Arial", 26, FontStyle.Bold);
        }
    }
}
