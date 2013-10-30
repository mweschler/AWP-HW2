namespace HWContLib
{
    partial class BaseDialogBox
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
            this.innerPanel = new System.Windows.Forms.Panel();
            this.courseboxBot = new HWContLib.Coursebox();
            this.nameboxTop = new HWContLib.Namebox();
            this.SuspendLayout();
            // 
            // innerPanel
            // 
            this.innerPanel.BackColor = System.Drawing.Color.Transparent;
            this.innerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerPanel.Location = new System.Drawing.Point(0, 78);
            this.innerPanel.Name = "innerPanel";
            this.innerPanel.Size = new System.Drawing.Size(284, 123);
            this.innerPanel.TabIndex = 2;
            // 
            // courseboxBot
            // 
            this.courseboxBot.BackColor = System.Drawing.Color.Transparent;
            this.courseboxBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.courseboxBot.Location = new System.Drawing.Point(0, 201);
            this.courseboxBot.Name = "courseboxBot";
            this.courseboxBot.Size = new System.Drawing.Size(284, 61);
            this.courseboxBot.TabIndex = 1;
            // 
            // nameboxTop
            // 
            this.nameboxTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nameboxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameboxTop.Location = new System.Drawing.Point(0, 0);
            this.nameboxTop.Name = "nameboxTop";
            this.nameboxTop.Size = new System.Drawing.Size(284, 78);
            this.nameboxTop.TabIndex = 0;
            // 
            // BaseDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.innerPanel);
            this.Controls.Add(this.courseboxBot);
            this.Controls.Add(this.nameboxTop);
            this.Name = "BaseDialogBox";
            this.Text = "BaseDialogBox";
            this.ResumeLayout(false);

        }

        #endregion

        private Namebox nameboxTop;
        private Coursebox courseboxBot;
        protected System.Windows.Forms.Panel innerPanel;
    }
}