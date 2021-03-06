using System.Windows.Forms;

namespace WinLinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            Form2 aForm = new Form2();
            aResult = aForm.ShowDialog();
            if (aResult == DialogResult.OK)
            {
                MessageBox.Show($"Your name is {aForm.textBox1.Text} {aForm.textBox2.Text}");
            }
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://docs.microsoft.com/");
            linkLabel2.LinkVisited = true;
        }
    }
}
