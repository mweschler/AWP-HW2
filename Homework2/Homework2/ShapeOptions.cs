using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW1ContLib;

namespace Homework2
{
    public partial class ShapeOptions : BaseDialogBox, IShapeProperties, IAppliable
    {
        public ShapeOptions()
        {
            InitializeComponent();
        }

        public event EventHandler Apply;

        public ShapeEnum ShapeType 
        {
            get 
            {
                return HWShape.stringToType(this.shapeCombo.SelectedText);
            }
            set 
            {
                this.shapeCombo.SelectedText = HWShape.typeToString(value);
            }
        }

        public Point ShapeLocation
        {
            get 
            { 
                return new Point(int.Parse(this.locXTextBox.Text), 
                    int.Parse(this.locYTextBox.Text)); 
            }
            set
            {
                this.locXTextBox.Text = value.X.ToString();
                this.locYTextBox.Text = value.Y.ToString();
            }
        }

        public Size ShapeSize
        {
            get
            {
                return new Size(int.Parse(this.sizeWidthTextBox.Text),
                    int.Parse(this.sizeHeightTextBox.Text));
            }

            set
            {
                this.sizeWidthTextBox.Text = value.Width.ToString();
                this.sizeHeightTextBox.Text = value.Height.ToString();
            }

        }

        public SizeF ShapeScale
        {
            get
            {
                return new SizeF(float.Parse(this.scaleWidthLabel.Text),
                    float.Parse(this.scaleHeightTextBox.Text));
            }

            set
            {
                this.scaleWidthTextBox.Text = value.Width.ToString();
                this.scaleHeightTextBox.Text = value.Height.ToString();
            }
        }

        public Point ShapeTranslation
        {
            get
            {
                return new Point(int.Parse(this.transXTextBox.Text),
                    int.Parse(this.transYTextBox.Text));
            }

            set
            {
                this.transXTextBox.Text = value.X.ToString();
                this.transYTextBox.Text = value.Y.ToString();
            }
        }

        public float ShapeRotation
        {
            get { return float.Parse(this.rotationTextBox.Text); }
            set { this.rotationTextBox.Text = value.ToString(); }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) 
            {
                if (!this.Modal)
                    Apply(this, EventArgs.Empty);

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Apply(this, EventArgs.Empty);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ShapeOptions_Load(object sender, EventArgs e)
        {
            if (this.Modal)
                applyButton.Enabled = false;
        }


    }
}
