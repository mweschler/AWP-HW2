namespace HW1ContLib
{
    partial class Coursebox
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
            this.Class = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Class
            // 
            this.Class.BackColor = System.Drawing.Color.Transparent;
            this.Class.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Class.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.ForeColor = System.Drawing.Color.Teal;
            this.Class.Location = new System.Drawing.Point(0, 0);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(224, 28);
            this.Class.TabIndex = 0;
            this.Class.Text = "COP4226";
            this.Class.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semester
            // 
            this.semester.BackColor = System.Drawing.Color.Transparent;
            this.semester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semester.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.ForeColor = System.Drawing.Color.Teal;
            this.semester.Location = new System.Drawing.Point(0, 0);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(224, 29);
            this.semester.TabIndex = 1;
            this.semester.Text = "Fall 2013";
            this.semester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.Class);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.semester);
            this.splitContainer.Size = new System.Drawing.Size(224, 61);
            this.splitContainer.SplitterDistance = 28;
            this.splitContainer.TabIndex = 2;
            // 
            // Coursebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer);
            this.Name = "Coursebox";
            this.Size = new System.Drawing.Size(224, 61);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label semester;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}
