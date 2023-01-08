namespace Hostel_Managment_system
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
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.readapp = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // gunaGradientButton3
            // 
            this.gunaGradientButton3.Animated = true;
            this.gunaGradientButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton3.AnimationSpeed = 0.03F;
            this.gunaGradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton3.BaseColor1 = System.Drawing.Color.MidnightBlue;
            this.gunaGradientButton3.BaseColor2 = System.Drawing.Color.Blue;
            this.gunaGradientButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton3.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.Image = null;
            this.gunaGradientButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton3.Location = new System.Drawing.Point(1098, 658);
            this.gunaGradientButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Radius = 20;
            this.gunaGradientButton3.Size = new System.Drawing.Size(274, 85);
            this.gunaGradientButton3.TabIndex = 10;
            this.gunaGradientButton3.Text = "Mark as Read...";
            this.gunaGradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton3.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Student Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // readapp
            // 
            this.readapp.BaseColor = System.Drawing.Color.White;
            this.readapp.BorderColor = System.Drawing.Color.Silver;
            this.readapp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.readapp.FocusedBaseColor = System.Drawing.Color.White;
            this.readapp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.readapp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.readapp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.readapp.Location = new System.Drawing.Point(42, 182);
            this.readapp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readapp.Name = "readapp";
            this.readapp.PasswordChar = '\0';
            this.readapp.SelectedText = "";
            this.readapp.Size = new System.Drawing.Size(1330, 440);
            this.readapp.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 803);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readapp);
            this.Controls.Add(this.gunaGradientButton3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox readapp;
    }
}