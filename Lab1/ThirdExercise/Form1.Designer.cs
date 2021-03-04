
namespace ThirdExercise
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(279, 62);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(75, 23);
            this.CloseFormButton.TabIndex = 0;
            this.CloseFormButton.Text = "Close From";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseFormButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BackColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button CloseFormButton;
    }
}

