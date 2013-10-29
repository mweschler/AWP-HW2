namespace HW1ContLib
{
    partial class Oathbox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oathbox));
            this.oath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oath
            // 
            this.oath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oath.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oath.ForeColor = System.Drawing.Color.Teal;
            this.oath.Location = new System.Drawing.Point(0, 0);
            this.oath.Name = "oath";
            this.oath.Size = new System.Drawing.Size(521, 240);
            this.oath.TabIndex = 0;
            this.oath.Text = resources.GetString("oath.Text");
            this.oath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Oathbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.oath);
            this.Name = "Oathbox";
            this.Size = new System.Drawing.Size(521, 240);
            this.Load += new System.EventHandler(this.Oathbox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label oath;
    }
}
