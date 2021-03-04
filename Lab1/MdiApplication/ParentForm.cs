using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private uint _openDocuments = 1;

        public ParentForm()
        {
            InitializeComponent();

            FileMenuItem.Click += FileMenuItem_Click;
            NewMenuItem.Click += NewMenuItem_Click;
            WindowCascadeMenuItem.Click += WindowCascadeMenuItem_Click;
            WindowTileMenuItem.Click += WindowTileMenuItem_Click;
            ExitMenuItem.Click += ExitMenuItem_Click;
        }

        private void FileMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewMdiChild();
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewMdiChild();
        }

        private void CreateNewMdiChild()
        {
            ChildForm newChild = new ChildForm
            {
                MdiParent = this,
                Text = $"{Text} #{_openDocuments++}",
            };
            newChild.Show();

            newChild.FormClosed += new FormClosedEventHandler((sender, e) =>
            {
                _openDocuments--;
            });
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
