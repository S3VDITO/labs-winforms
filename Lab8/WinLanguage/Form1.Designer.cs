
namespace WinLanguage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandIneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // MainMenuItem
            // 
            resources.ApplyResources(this.MainMenuItem, "MainMenuItem");
            this.MainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandIneToolStripMenuItem,
            this.commandTwoToolStripMenuItem});
            this.MainMenuItem.Name = "MainMenuItem";
            // 
            // commandIneToolStripMenuItem
            // 
            resources.ApplyResources(this.commandIneToolStripMenuItem, "commandIneToolStripMenuItem");
            this.commandIneToolStripMenuItem.Name = "commandIneToolStripMenuItem";
            // 
            // commandTwoToolStripMenuItem
            // 
            resources.ApplyResources(this.commandTwoToolStripMenuItem, "commandTwoToolStripMenuItem");
            this.commandTwoToolStripMenuItem.Name = "commandTwoToolStripMenuItem";
            // 
            // closeToolStripMenuItem
            // 
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandIneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandTwoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

