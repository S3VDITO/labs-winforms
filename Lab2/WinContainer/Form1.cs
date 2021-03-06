using System;
using System.Windows.Forms;

namespace WinContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                but.Text = "First";
            }
            else if (radioButton2.Checked == true)
            {
                but.Text = "Second";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SetFlowBreak(button6, true);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button aButton = new Button();
            tableLayoutPanel1.Controls.Add(aButton, 1, 1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (splitContainer1.FixedPanel == FixedPanel.Panel1)
            {
                splitContainer1.FixedPanel = FixedPanel.None;
            }
            else
            {
                splitContainer1.FixedPanel = FixedPanel.Panel1;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            splitContainer1.IsSplitterFixed = !(splitContainer1.IsSplitterFixed);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !(splitContainer1.Panel1Collapsed);
        }
    }
}
