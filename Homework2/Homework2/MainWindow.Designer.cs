namespace Homework2
{
    partial class MainWindow
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
            this.mainMenuExtend = new System.Windows.Forms.MenuStrip();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidPenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rectButton = new System.Windows.Forms.ToolStripButton();
            this.ellipseButton = new System.Windows.Forms.ToolStripButton();
            this.triangleButton = new System.Windows.Forms.ToolStripButton();
            this.solidPenButton = new System.Windows.Forms.ToolStripButton();
            this.dashedPenButton = new System.Windows.Forms.ToolStripButton();
            this.compundPenButton = new System.Windows.Forms.ToolStripButton();
            this.solidBrushButton = new System.Windows.Forms.ToolStripButton();
            this.hatchedBrushButton = new System.Windows.Forms.ToolStripButton();
            this.gradientBrushButton = new System.Windows.Forms.ToolStripButton();
            this.penColorButton = new System.Windows.Forms.ToolStripButton();
            this.brushColorButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenuExtend.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Size = new System.Drawing.Size(563, 388);
            // 
            // namebox1
            // 
            this.namebox1.Location = new System.Drawing.Point(0, 49);
            // 
            // mainMenuExtend
            // 
            this.mainMenuExtend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapeToolStripMenuItem,
            this.penToolStripMenuItem,
            this.brushToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.mainMenuExtend.Location = new System.Drawing.Point(0, 0);
            this.mainMenuExtend.Name = "mainMenuExtend";
            this.mainMenuExtend.Size = new System.Drawing.Size(563, 24);
            this.mainMenuExtend.TabIndex = 4;
            this.mainMenuExtend.Text = "mainMenuExtend";
            this.mainMenuExtend.Visible = false;
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.triangleToolStripMenuItem});
            this.shapeToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.shapeToolStripMenuItem.MergeIndex = 1;
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidPenToolStripMenuItem,
            this.dashedToolStripMenuItem,
            this.compoundToolStripMenuItem});
            this.penToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.penToolStripMenuItem.MergeIndex = 2;
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.penToolStripMenuItem.Text = "Pen";
            // 
            // solidPenToolStripMenuItem
            // 
            this.solidPenToolStripMenuItem.Name = "solidPenToolStripMenuItem";
            this.solidPenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.solidPenToolStripMenuItem.Text = "Solid";
            this.solidPenToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // dashedToolStripMenuItem
            // 
            this.dashedToolStripMenuItem.Name = "dashedToolStripMenuItem";
            this.dashedToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.dashedToolStripMenuItem.Text = "Dashed";
            this.dashedToolStripMenuItem.Click += new System.EventHandler(this.dashedToolStripMenuItem_Click);
            // 
            // compoundToolStripMenuItem
            // 
            this.compoundToolStripMenuItem.Name = "compoundToolStripMenuItem";
            this.compoundToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.compoundToolStripMenuItem.Text = "Compound";
            this.compoundToolStripMenuItem.Click += new System.EventHandler(this.compoundToolStripMenuItem_Click);
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidBrushToolStripMenuItem,
            this.hatchToolStripMenuItem,
            this.gradientToolStripMenuItem});
            this.brushToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.brushToolStripMenuItem.MergeIndex = 3;
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.brushToolStripMenuItem.Text = "Brush";
            // 
            // solidBrushToolStripMenuItem
            // 
            this.solidBrushToolStripMenuItem.Name = "solidBrushToolStripMenuItem";
            this.solidBrushToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.solidBrushToolStripMenuItem.Text = "Solid";
            this.solidBrushToolStripMenuItem.Click += new System.EventHandler(this.solidBrushToolStripMenuItem_Click);
            // 
            // hatchToolStripMenuItem
            // 
            this.hatchToolStripMenuItem.Name = "hatchToolStripMenuItem";
            this.hatchToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hatchToolStripMenuItem.Text = "Hatch";
            this.hatchToolStripMenuItem.Click += new System.EventHandler(this.hatchToolStripMenuItem_Click);
            // 
            // gradientToolStripMenuItem
            // 
            this.gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
            this.gradientToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.gradientToolStripMenuItem.Text = "Gradient";
            this.gradientToolStripMenuItem.Click += new System.EventHandler(this.gradientToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penToolStripMenuItem1,
            this.brushToolStripMenuItem1});
            this.colorToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.colorToolStripMenuItem.MergeIndex = 4;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // penToolStripMenuItem1
            // 
            this.penToolStripMenuItem1.Name = "penToolStripMenuItem1";
            this.penToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.penToolStripMenuItem1.Text = "Pen";
            this.penToolStripMenuItem1.Click += new System.EventHandler(this.setPenColor);
            // 
            // brushToolStripMenuItem1
            // 
            this.brushToolStripMenuItem1.Name = "brushToolStripMenuItem1";
            this.brushToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.brushToolStripMenuItem1.Text = "Brush";
            this.brushToolStripMenuItem1.Click += new System.EventHandler(this.setBrushColor);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectButton,
            this.ellipseButton,
            this.triangleButton,
            this.toolStripSeparator1,
            this.solidPenButton,
            this.dashedPenButton,
            this.compundPenButton,
            this.toolStripSeparator2,
            this.solidBrushButton,
            this.hatchedBrushButton,
            this.gradientBrushButton,
            this.toolStripSeparator3,
            this.penColorButton,
            this.brushColorButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(563, 25);
            this.mainToolStrip.TabIndex = 5;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // rectButton
            // 
            this.rectButton.Checked = true;
            this.rectButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectButton.Image = global::Homework2.Properties.Resources.Rectangle;
            this.rectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectButton.Name = "rectButton";
            this.rectButton.Size = new System.Drawing.Size(23, 22);
            this.rectButton.Text = "toolStripButton1";
            this.rectButton.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseButton.Image = global::Homework2.Properties.Resources.Ellipse;
            this.ellipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(23, 22);
            this.ellipseButton.Text = "toolStripButton2";
            this.ellipseButton.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.triangleButton.Image = global::Homework2.Properties.Resources.Triangle;
            this.triangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(23, 22);
            this.triangleButton.Text = "toolStripButton3";
            this.triangleButton.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // solidPenButton
            // 
            this.solidPenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.solidPenButton.Image = global::Homework2.Properties.Resources.solidPen;
            this.solidPenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.solidPenButton.Name = "solidPenButton";
            this.solidPenButton.Size = new System.Drawing.Size(23, 22);
            this.solidPenButton.Text = "toolStripButton4";
            this.solidPenButton.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // dashedPenButton
            // 
            this.dashedPenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dashedPenButton.Image = global::Homework2.Properties.Resources.dashedPen;
            this.dashedPenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dashedPenButton.Name = "dashedPenButton";
            this.dashedPenButton.Size = new System.Drawing.Size(23, 22);
            this.dashedPenButton.Text = "toolStripButton5";
            this.dashedPenButton.Click += new System.EventHandler(this.dashedToolStripMenuItem_Click);
            // 
            // compundPenButton
            // 
            this.compundPenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compundPenButton.Image = global::Homework2.Properties.Resources.compoundPen;
            this.compundPenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.compundPenButton.Name = "compundPenButton";
            this.compundPenButton.Size = new System.Drawing.Size(23, 22);
            this.compundPenButton.Text = "toolStripButton6";
            this.compundPenButton.Click += new System.EventHandler(this.compoundToolStripMenuItem_Click);
            // 
            // solidBrushButton
            // 
            this.solidBrushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.solidBrushButton.Image = global::Homework2.Properties.Resources.solidBrush;
            this.solidBrushButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.solidBrushButton.Name = "solidBrushButton";
            this.solidBrushButton.Size = new System.Drawing.Size(23, 22);
            this.solidBrushButton.Text = "toolStripButton7";
            this.solidBrushButton.Click += new System.EventHandler(this.solidBrushToolStripMenuItem_Click);
            // 
            // hatchedBrushButton
            // 
            this.hatchedBrushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hatchedBrushButton.Image = global::Homework2.Properties.Resources.hatchBrush;
            this.hatchedBrushButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hatchedBrushButton.Name = "hatchedBrushButton";
            this.hatchedBrushButton.Size = new System.Drawing.Size(23, 22);
            this.hatchedBrushButton.Text = "toolStripButton8";
            this.hatchedBrushButton.Click += new System.EventHandler(this.hatchToolStripMenuItem_Click);
            // 
            // gradientBrushButton
            // 
            this.gradientBrushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gradientBrushButton.Image = global::Homework2.Properties.Resources.gradient;
            this.gradientBrushButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gradientBrushButton.Name = "gradientBrushButton";
            this.gradientBrushButton.Size = new System.Drawing.Size(23, 22);
            this.gradientBrushButton.Text = "toolStripButton9";
            this.gradientBrushButton.Click += new System.EventHandler(this.gradientToolStripMenuItem_Click);
            // 
            // penColorButton
            // 
            this.penColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penColorButton.Image = global::Homework2.Properties.Resources.colorButton;
            this.penColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(23, 22);
            this.penColorButton.Text = "toolStripButton1";
            this.penColorButton.Click += new System.EventHandler(this.setPenColor);
            // 
            // brushColorButton
            // 
            this.brushColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushColorButton.Image = global::Homework2.Properties.Resources.colorBrushButton;
            this.brushColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brushColorButton.Name = "brushColorButton";
            this.brushColorButton.Size = new System.Drawing.Size(23, 22);
            this.brushColorButton.Text = "toolStripButton2";
            this.brushColorButton.Click += new System.EventHandler(this.setBrushColor);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 434);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuExtend);
            this.Name = "MainWindow";
            this.Text = "Homework2";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Controls.SetChildIndex(this.mainMenuExtend, 0);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.mainToolStrip, 0);
            this.Controls.SetChildIndex(this.namebox1, 0);
            this.mainMenuExtend.ResumeLayout(false);
            this.mainMenuExtend.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuExtend;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidPenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton rectButton;
        private System.Windows.Forms.ToolStripButton ellipseButton;
        private System.Windows.Forms.ToolStripButton triangleButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton solidPenButton;
        private System.Windows.Forms.ToolStripButton dashedPenButton;
        private System.Windows.Forms.ToolStripButton compundPenButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton solidBrushButton;
        private System.Windows.Forms.ToolStripButton hatchedBrushButton;
        private System.Windows.Forms.ToolStripButton gradientBrushButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton penColorButton;
        private System.Windows.Forms.ToolStripButton brushColorButton;

    }
}

