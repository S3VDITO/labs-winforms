using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinButNum
{
    public class ClickButton : Button
    {
        public int Clicks { get; private set; } = 0;

        protected override void OnClick(EventArgs e)
        {
            Clicks++;
            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;

            SizeF stringsize;
            stringsize = g.MeasureString(
                Clicks.ToString(),
                Font,
                Width);

            pevent.Graphics.DrawString(
                Clicks.ToString(),
                Font, new SolidBrush(ForeColor),
                Width - stringsize.Width - 3,
                Height -stringsize.Height - 3);
        }
    }
}
