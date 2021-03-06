using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы pdf|*.pdf";
            openFileDialog1.ShowDialog();
            axAcroPDF1.LoadFile(openFileDialog1.FileName);
        }
    }
}
