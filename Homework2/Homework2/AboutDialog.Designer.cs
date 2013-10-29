namespace Homework2
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.aboutDescription = new System.Windows.Forms.Label();
            this.innerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // innerPanel
            // 
            this.innerPanel.Controls.Add(this.aboutDescription);
            this.innerPanel.Size = new System.Drawing.Size(502, 185);
            // 
            // aboutDescription
            // 
            this.aboutDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutDescription.Location = new System.Drawing.Point(0, 0);
            this.aboutDescription.Name = "aboutDescription";
            this.aboutDescription.Size = new System.Drawing.Size(502, 185);
            this.aboutDescription.TabIndex = 0;
            this.aboutDescription.Text = resources.GetString("aboutDescription.Text");
            this.aboutDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(502, 324);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.Text = "About";
            this.innerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aboutDescription;
    }
}
