using System;
using System.Windows.Forms;

namespace WinAnim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAW_BLEND_Click(object sender, EventArgs e)
        {
            // Скрываем окно
            Hide();

            // Запускаем анимацию.
            // Второй параметр в скобках — время анимации в
            // миллисекундах. 
            WinAPIClass.AnimateWindow(
                this,
                3000,
                WinAPIClass.AnimateWindowFlags.AW_ACTIVATE | WinAPIClass.AnimateWindowFlags.AW_BLEND);

            // Отображаем кнопки после анимации
            btnAW_BLEND.Invalidate();
            btnHOR_AW_SLIDE.Invalidate();
            btnCenter_AW_SLIDE.Invalidate();
        }
        private void btnHOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            Hide();

            WinAPIClass.AnimateWindow(
                this,
                3000,
                WinAPIClass.AnimateWindowFlags.AW_HOR_POSITIVE | WinAPIClass.AnimateWindowFlags.AW_SLIDE);

            btnAW_BLEND.Invalidate();
            btnHOR_AW_SLIDE.Invalidate();
            btnCenter_AW_SLIDE.Invalidate();
        }
        private void btnCenter_AW_SLIDE_Click(object sender, EventArgs e)
        {
            Hide();

            WinAPIClass.AnimateWindow(
                this,
                3000,
                WinAPIClass.AnimateWindowFlags.AW_CENTER | WinAPIClass.AnimateWindowFlags.AW_SLIDE);

            btnAW_BLEND.Invalidate();
            btnHOR_AW_SLIDE.Invalidate();
            btnCenter_AW_SLIDE.Invalidate();
        }
    }
}
