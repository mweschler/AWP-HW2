namespace Homework2
{
    partial class ShapeOptions
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
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.propertiesPanel = new System.Windows.Forms.Panel();
            this.splitProperties = new System.Windows.Forms.SplitContainer();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeHeightTextBox = new System.Windows.Forms.TextBox();
            this.sizeHeightLabel = new System.Windows.Forms.Label();
            this.sizeWidthLabel = new System.Windows.Forms.Label();
            this.sizeWidthTextBox = new System.Windows.Forms.TextBox();
            this.locationGroup = new System.Windows.Forms.GroupBox();
            this.locYLabel = new System.Windows.Forms.Label();
            this.locYTextBox = new System.Windows.Forms.TextBox();
            this.locXLabel = new System.Windows.Forms.Label();
            this.locXTextBox = new System.Windows.Forms.TextBox();
            this.shapeCombo = new System.Windows.Forms.ComboBox();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.translationGroup = new System.Windows.Forms.GroupBox();
            this.transYLabel = new System.Windows.Forms.Label();
            this.transYTextBox = new System.Windows.Forms.TextBox();
            this.transXLabel = new System.Windows.Forms.Label();
            this.transXTextBox = new System.Windows.Forms.TextBox();
            this.scaleGroup = new System.Windows.Forms.GroupBox();
            this.scaleHeigthLabel = new System.Windows.Forms.Label();
            this.scaleWidthLabel = new System.Windows.Forms.Label();
            this.scaleHeightTextBox = new System.Windows.Forms.TextBox();
            this.scaleWidthTextBox = new System.Windows.Forms.TextBox();
            this.rotationLabel = new System.Windows.Forms.Label();
            this.rotationTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.innerPanel.SuspendLayout();
            this.propertiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitProperties)).BeginInit();
            this.splitProperties.Panel1.SuspendLayout();
            this.splitProperties.Panel2.SuspendLayout();
            this.splitProperties.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            this.locationGroup.SuspendLayout();
            this.translationGroup.SuspendLayout();
            this.scaleGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // innerPanel
            // 
            this.innerPanel.Controls.Add(this.propertiesPanel);
            this.innerPanel.Controls.Add(this.applyButton);
            this.innerPanel.Controls.Add(this.cancelButton);
            this.innerPanel.Padding = new System.Windows.Forms.Padding(10);
            this.innerPanel.Size = new System.Drawing.Size(473, 319);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(376, 280);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(295, 280);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.Controls.Add(this.splitProperties);
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertiesPanel.Location = new System.Drawing.Point(10, 10);
            this.propertiesPanel.Margin = new System.Windows.Forms.Padding(5);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Size = new System.Drawing.Size(453, 258);
            this.propertiesPanel.TabIndex = 3;
            // 
            // splitProperties
            // 
            this.splitProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitProperties.Location = new System.Drawing.Point(0, 0);
            this.splitProperties.Name = "splitProperties";
            // 
            // splitProperties.Panel1
            // 
            this.splitProperties.Panel1.Controls.Add(this.sizeGroupBox);
            this.splitProperties.Panel1.Controls.Add(this.locationGroup);
            this.splitProperties.Panel1.Controls.Add(this.shapeCombo);
            this.splitProperties.Panel1.Controls.Add(this.shapeLabel);
            this.splitProperties.Panel1.Padding = new System.Windows.Forms.Padding(15);
            // 
            // splitProperties.Panel2
            // 
            this.splitProperties.Panel2.Controls.Add(this.translationGroup);
            this.splitProperties.Panel2.Controls.Add(this.scaleGroup);
            this.splitProperties.Panel2.Controls.Add(this.rotationLabel);
            this.splitProperties.Panel2.Controls.Add(this.rotationTextBox);
            this.splitProperties.Size = new System.Drawing.Size(453, 258);
            this.splitProperties.SplitterDistance = 238;
            this.splitProperties.TabIndex = 2;
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeGroupBox.Controls.Add(this.sizeHeightTextBox);
            this.sizeGroupBox.Controls.Add(this.sizeHeightLabel);
            this.sizeGroupBox.Controls.Add(this.sizeWidthLabel);
            this.sizeGroupBox.Controls.Add(this.sizeWidthTextBox);
            this.sizeGroupBox.Location = new System.Drawing.Point(0, 145);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(237, 100);
            this.sizeGroupBox.TabIndex = 3;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // sizeHeightTextBox
            // 
            this.sizeHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeHeightTextBox.Location = new System.Drawing.Point(94, 45);
            this.sizeHeightTextBox.Name = "sizeHeightTextBox";
            this.sizeHeightTextBox.Size = new System.Drawing.Size(118, 20);
            this.sizeHeightTextBox.TabIndex = 3;
            this.sizeHeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateIntNoNegative);
            // 
            // sizeHeightLabel
            // 
            this.sizeHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeHeightLabel.AutoSize = true;
            this.sizeHeightLabel.Location = new System.Drawing.Point(47, 48);
            this.sizeHeightLabel.Name = "sizeHeightLabel";
            this.sizeHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.sizeHeightLabel.TabIndex = 2;
            this.sizeHeightLabel.Text = "Height:";
            // 
            // sizeWidthLabel
            // 
            this.sizeWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeWidthLabel.AutoSize = true;
            this.sizeWidthLabel.Location = new System.Drawing.Point(50, 22);
            this.sizeWidthLabel.Name = "sizeWidthLabel";
            this.sizeWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.sizeWidthLabel.TabIndex = 1;
            this.sizeWidthLabel.Text = "Width:";
            this.sizeWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sizeWidthTextBox
            // 
            this.sizeWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeWidthTextBox.Location = new System.Drawing.Point(94, 19);
            this.sizeWidthTextBox.Name = "sizeWidthTextBox";
            this.sizeWidthTextBox.Size = new System.Drawing.Size(118, 20);
            this.sizeWidthTextBox.TabIndex = 0;
            this.sizeWidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateIntNoNegative);
            // 
            // locationGroup
            // 
            this.locationGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationGroup.Controls.Add(this.locYLabel);
            this.locationGroup.Controls.Add(this.locYTextBox);
            this.locationGroup.Controls.Add(this.locXLabel);
            this.locationGroup.Controls.Add(this.locXTextBox);
            this.locationGroup.Location = new System.Drawing.Point(0, 58);
            this.locationGroup.Name = "locationGroup";
            this.locationGroup.Size = new System.Drawing.Size(237, 81);
            this.locationGroup.TabIndex = 2;
            this.locationGroup.TabStop = false;
            this.locationGroup.Text = "Location";
            // 
            // locYLabel
            // 
            this.locYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locYLabel.AutoSize = true;
            this.locYLabel.Location = new System.Drawing.Point(71, 48);
            this.locYLabel.Name = "locYLabel";
            this.locYLabel.Size = new System.Drawing.Size(17, 13);
            this.locYLabel.TabIndex = 3;
            this.locYLabel.Text = "Y:";
            // 
            // locYTextBox
            // 
            this.locYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locYTextBox.Location = new System.Drawing.Point(102, 45);
            this.locYTextBox.Name = "locYTextBox";
            this.locYTextBox.Size = new System.Drawing.Size(118, 20);
            this.locYTextBox.TabIndex = 2;
            this.locYTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateIntNoNegative);
            // 
            // locXLabel
            // 
            this.locXLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locXLabel.AutoSize = true;
            this.locXLabel.Location = new System.Drawing.Point(71, 22);
            this.locXLabel.Name = "locXLabel";
            this.locXLabel.Size = new System.Drawing.Size(17, 13);
            this.locXLabel.TabIndex = 1;
            this.locXLabel.Text = "X:";
            // 
            // locXTextBox
            // 
            this.locXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locXTextBox.Location = new System.Drawing.Point(102, 19);
            this.locXTextBox.Name = "locXTextBox";
            this.locXTextBox.Size = new System.Drawing.Size(118, 20);
            this.locXTextBox.TabIndex = 0;
            this.locXTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateIntNoNegative);
            // 
            // shapeCombo
            // 
            this.shapeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeCombo.FormattingEnabled = true;
            this.shapeCombo.Items.AddRange(new object[] {
            "Triangle",
            "Ellipse",
            "Rectangle"});
            this.shapeCombo.Location = new System.Drawing.Point(102, 18);
            this.shapeCombo.Name = "shapeCombo";
            this.shapeCombo.Size = new System.Drawing.Size(118, 21);
            this.shapeCombo.TabIndex = 0;
            this.shapeCombo.Validating += new System.ComponentModel.CancelEventHandler(this.shapeCombo_Validating);
            // 
            // shapeLabel
            // 
            this.shapeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(58, 21);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(38, 13);
            this.shapeLabel.TabIndex = 1;
            this.shapeLabel.Text = "Shape";
            this.shapeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // translationGroup
            // 
            this.translationGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.translationGroup.Controls.Add(this.transYLabel);
            this.translationGroup.Controls.Add(this.transYTextBox);
            this.translationGroup.Controls.Add(this.transXLabel);
            this.translationGroup.Controls.Add(this.transXTextBox);
            this.translationGroup.Location = new System.Drawing.Point(1, 145);
            this.translationGroup.Name = "translationGroup";
            this.translationGroup.Size = new System.Drawing.Size(209, 100);
            this.translationGroup.TabIndex = 3;
            this.translationGroup.TabStop = false;
            this.translationGroup.Text = "Translation";
            // 
            // transYLabel
            // 
            this.transYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transYLabel.AutoSize = true;
            this.transYLabel.Location = new System.Drawing.Point(57, 52);
            this.transYLabel.Name = "transYLabel";
            this.transYLabel.Size = new System.Drawing.Size(17, 13);
            this.transYLabel.TabIndex = 3;
            this.transYLabel.Text = "Y:";
            // 
            // transYTextBox
            // 
            this.transYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transYTextBox.Location = new System.Drawing.Point(80, 48);
            this.transYTextBox.Name = "transYTextBox";
            this.transYTextBox.Size = new System.Drawing.Size(118, 20);
            this.transYTextBox.TabIndex = 2;
            this.transYTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateIntTextBox);
            // 
            // transXLabel
            // 
            this.transXLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transXLabel.AutoSize = true;
            this.transXLabel.Location = new System.Drawing.Point(57, 22);
            this.transXLabel.Name = "transXLabel";
            this.transXLabel.Size = new System.Drawing.Size(17, 13);
            this.transXLabel.TabIndex = 1;
            this.transXLabel.Text = "X:";
            // 
            // transXTextBox
            // 
            this.transXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transXTextBox.Location = new System.Drawing.Point(80, 19);
            this.transXTextBox.Name = "transXTextBox";
            this.transXTextBox.Size = new System.Drawing.Size(118, 20);
            this.transXTextBox.TabIndex = 0;
            this.transXTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateIntTextBox);
            // 
            // scaleGroup
            // 
            this.scaleGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleGroup.Controls.Add(this.scaleHeigthLabel);
            this.scaleGroup.Controls.Add(this.scaleWidthLabel);
            this.scaleGroup.Controls.Add(this.scaleHeightTextBox);
            this.scaleGroup.Controls.Add(this.scaleWidthTextBox);
            this.scaleGroup.Location = new System.Drawing.Point(1, 58);
            this.scaleGroup.Name = "scaleGroup";
            this.scaleGroup.Size = new System.Drawing.Size(209, 80);
            this.scaleGroup.TabIndex = 2;
            this.scaleGroup.TabStop = false;
            this.scaleGroup.Text = "Scale";
            // 
            // scaleHeigthLabel
            // 
            this.scaleHeigthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleHeigthLabel.AutoSize = true;
            this.scaleHeigthLabel.Location = new System.Drawing.Point(41, 48);
            this.scaleHeigthLabel.Name = "scaleHeigthLabel";
            this.scaleHeigthLabel.Size = new System.Drawing.Size(41, 13);
            this.scaleHeigthLabel.TabIndex = 3;
            this.scaleHeigthLabel.Text = "Height:";
            // 
            // scaleWidthLabel
            // 
            this.scaleWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleWidthLabel.AutoSize = true;
            this.scaleWidthLabel.Location = new System.Drawing.Point(41, 22);
            this.scaleWidthLabel.Name = "scaleWidthLabel";
            this.scaleWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.scaleWidthLabel.TabIndex = 2;
            this.scaleWidthLabel.Text = "Width:";
            // 
            // scaleHeightTextBox
            // 
            this.scaleHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleHeightTextBox.Location = new System.Drawing.Point(85, 45);
            this.scaleHeightTextBox.Name = "scaleHeightTextBox";
            this.scaleHeightTextBox.Size = new System.Drawing.Size(118, 20);
            this.scaleHeightTextBox.TabIndex = 1;
            this.scaleHeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateFloat);
            // 
            // scaleWidthTextBox
            // 
            this.scaleWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleWidthTextBox.Location = new System.Drawing.Point(85, 19);
            this.scaleWidthTextBox.Name = "scaleWidthTextBox";
            this.scaleWidthTextBox.Size = new System.Drawing.Size(118, 20);
            this.scaleWidthTextBox.TabIndex = 0;
            this.scaleWidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateFloat);
            // 
            // rotationLabel
            // 
            this.rotationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationLabel.AutoSize = true;
            this.rotationLabel.Location = new System.Drawing.Point(25, 18);
            this.rotationLabel.Name = "rotationLabel";
            this.rotationLabel.Size = new System.Drawing.Size(50, 13);
            this.rotationLabel.TabIndex = 1;
            this.rotationLabel.Text = "Rotation:";
            // 
            // rotationTextBox
            // 
            this.rotationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationTextBox.Location = new System.Drawing.Point(81, 14);
            this.rotationTextBox.Name = "rotationTextBox";
            this.rotationTextBox.Size = new System.Drawing.Size(118, 20);
            this.rotationTextBox.TabIndex = 0;
            this.rotationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateIntTextBox);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ShapeOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(473, 458);
            this.MinimumSize = new System.Drawing.Size(489, 496);
            this.Name = "ShapeOptions";
            this.Text = "Shape Properties";
            this.Load += new System.EventHandler(this.ShapeOptions_Load);
            this.innerPanel.ResumeLayout(false);
            this.propertiesPanel.ResumeLayout(false);
            this.splitProperties.Panel1.ResumeLayout(false);
            this.splitProperties.Panel1.PerformLayout();
            this.splitProperties.Panel2.ResumeLayout(false);
            this.splitProperties.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitProperties)).EndInit();
            this.splitProperties.ResumeLayout(false);
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.locationGroup.ResumeLayout(false);
            this.locationGroup.PerformLayout();
            this.translationGroup.ResumeLayout(false);
            this.translationGroup.PerformLayout();
            this.scaleGroup.ResumeLayout(false);
            this.scaleGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel propertiesPanel;
        private System.Windows.Forms.SplitContainer splitProperties;
        private System.Windows.Forms.GroupBox locationGroup;
        private System.Windows.Forms.ComboBox shapeCombo;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label locXLabel;
        private System.Windows.Forms.TextBox locXTextBox;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.TextBox sizeHeightTextBox;
        private System.Windows.Forms.Label sizeHeightLabel;
        private System.Windows.Forms.Label sizeWidthLabel;
        private System.Windows.Forms.TextBox sizeWidthTextBox;
        private System.Windows.Forms.Label locYLabel;
        private System.Windows.Forms.TextBox locYTextBox;
        private System.Windows.Forms.GroupBox translationGroup;
        private System.Windows.Forms.Label transYLabel;
        private System.Windows.Forms.TextBox transYTextBox;
        private System.Windows.Forms.Label transXLabel;
        private System.Windows.Forms.TextBox transXTextBox;
        private System.Windows.Forms.GroupBox scaleGroup;
        private System.Windows.Forms.Label scaleHeigthLabel;
        private System.Windows.Forms.Label scaleWidthLabel;
        private System.Windows.Forms.TextBox scaleHeightTextBox;
        private System.Windows.Forms.TextBox scaleWidthTextBox;
        private System.Windows.Forms.Label rotationLabel;
        private System.Windows.Forms.TextBox rotationTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}