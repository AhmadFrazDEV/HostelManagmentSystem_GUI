namespace Hostel_Managment_system
{
    partial class messageBox
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
            this.massagetxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // massagetxt
            // 
            this.massagetxt.Location = new System.Drawing.Point(12, 35);
            this.massagetxt.Multiline = true;
            this.massagetxt.Name = "massagetxt";
            this.massagetxt.Size = new System.Drawing.Size(698, 140);
            this.massagetxt.TabIndex = 0;
            // 
            // messageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 382);
            this.Controls.Add(this.massagetxt);
            this.Name = "messageBox";
            this.Text = "messageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox massagetxt;
    }
}