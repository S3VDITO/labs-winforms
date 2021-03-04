
namespace Task2
{
    partial class Form2
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
            this.OpenNewFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenNewFormButton
            // 
            this.OpenNewFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenNewFormButton.Location = new System.Drawing.Point(128, 128);
            this.OpenNewFormButton.Name = "OpenNewFormButton";
            this.OpenNewFormButton.Size = new System.Drawing.Size(208, 56);
            this.OpenNewFormButton.TabIndex = 0;
            this.OpenNewFormButton.Text = "Open GREENPEACE form";
            this.OpenNewFormButton.UseVisualStyleBackColor = true;
            this.OpenNewFormButton.Click += new System.EventHandler(this.OpenNewFormButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.OpenNewFormButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenNewFormButton;
    }
}