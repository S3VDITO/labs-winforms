using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTimer2
{
    public partial class UserControlTimer2 : Control
    {
        public UserControlTimer2()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;

            g.FillRectangle(Brushes.Blue, 0, 0, Width, Height);
            pe.Graphics.DrawString(DateTime.Now.ToLongTimeString(), Font, new SolidBrush(ForeColor), 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
