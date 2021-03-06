using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinTimer1
{
    public partial class UserControlTimer : UserControl
    {
        public UserControlTimer()
        {
            InitializeComponent();
        }

        public bool TimeEnabled
        {
            get => timer1.Enabled;
            set => timer1.Enabled = value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
