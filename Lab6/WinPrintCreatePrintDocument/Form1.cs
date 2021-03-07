using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WinPrint
{
    public partial class Form1 : Form
    {
        private string s;
        private string[] strings;
        private int ArrayCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            float MyLines = 0;
            float YPosition = 0;
            int Counter = 0;
            string CurrentLine;
            MyLines = e.MarginBounds.Height / Font.GetHeight(e.Graphics);

            while (Counter < MyLines && ArrayCounter <= strings.Length - 1)
            {
                CurrentLine = strings[ArrayCounter];
                YPosition = TopMargin + Counter * Font.GetHeight(e.Graphics);

                e.Graphics.DrawString(
                    CurrentLine,
                    Font,
                    Brushes.Black,
                    LeftMargin,
                    YPosition,
                    new StringFormat());

                Counter++;
                ArrayCounter++;
            }

            if (!(ArrayCounter >= strings.GetLength(0) - 1))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult aResult;
            aResult = openFileDialog1.ShowDialog();
            if (aResult == DialogResult.OK)
            {
                StreamReader aReader = new StreamReader(openFileDialog1.FileName);
                s = aReader.ReadToEnd();
                aReader.Close();
                strings = s.Split('\n');
            }
        }
    }
}
