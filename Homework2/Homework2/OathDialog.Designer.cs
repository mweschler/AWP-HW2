namespace Homework2
{
    partial class OathDialog
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
            this.oathbox1 = new HW1ContLib.Oathbox();
            this.innerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // innerPanel
            // 
            this.innerPanel.Controls.Add(this.oathbox1);
            this.innerPanel.Size = new System.Drawing.Size(502, 185);
            // 
            // oathbox1
            // 
            this.oathbox1.BackColor = System.Drawing.Color.Transparent;
            this.oathbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathbox1.Location = new System.Drawing.Point(0, 0);
            this.oathbox1.Name = "oathbox1";
            this.oathbox1.Size = new System.Drawing.Size(502, 185);
            this.oathbox1.TabIndex = 0;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(502, 324);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OathDialog";
            this.Text = "Oath Dialog";
            this.innerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HW1ContLib.Oathbox oathbox1;
    }
}
