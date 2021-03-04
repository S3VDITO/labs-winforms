
namespace FirstExercise
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
            this.BorderStyleButton = new System.Windows.Forms.Button();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.OpacityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BorderStyle
            // 
            this.BorderStyleButton.Location = new System.Drawing.Point(12, 12);
            this.BorderStyleButton.Name = "BorderStyle";
            this.BorderStyleButton.Size = new System.Drawing.Size(86, 23);
            this.BorderStyleButton.TabIndex = 0;
            this.BorderStyleButton.Text = "Border Style";
            this.BorderStyleButton.UseVisualStyleBackColor = true;
            this.BorderStyleButton.Click += new System.EventHandler(this.BorderStyle_Click);
            // 
            // Resize
            // 
            this.ResizeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResizeButton.Location = new System.Drawing.Point(12, 41);
            this.ResizeButton.Name = "Resize";
            this.ResizeButton.Size = new System.Drawing.Size(86, 23);
            this.ResizeButton.TabIndex = 1;
            this.ResizeButton.Text = "Resize";
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.Click += new System.EventHandler(this.Resize_Click);
            // 
            // Opacity
            // 
            this.OpacityButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpacityButton.Location = new System.Drawing.Point(12, 70);
            this.OpacityButton.Name = "Opacity";
            this.OpacityButton.Size = new System.Drawing.Size(86, 23);
            this.OpacityButton.TabIndex = 2;
            this.OpacityButton.Text = "Opacity";
            this.OpacityButton.UseVisualStyleBackColor = true;
            this.OpacityButton.Click += new System.EventHandler(this.Opacity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 280);
            this.Controls.Add(this.OpacityButton);
            this.Controls.Add(this.ResizeButton);
            this.Controls.Add(this.BorderStyleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Form1";
            this.Opacity = 0.75;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BorderStyleButton;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.Button OpacityButton;
    }
}

