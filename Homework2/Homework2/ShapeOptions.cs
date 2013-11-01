using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HWContLib;

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
                return HWShape.stringToType(this.shapeCombo.SelectedItem as string);
            }
            set 
            {
                this.shapeCombo.SelectedItem = HWShape.typeToString(value);
                //this.shapeCombo.SelectedText = HWShape.typeToString(value);
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
                return new SizeF(float.Parse(this.scaleWidthTextBox.Text),
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

        //Validate any integer
        private void validateIntTextBox(object sender, CancelEventArgs e)
        {
            if (!(sender is TextBox))
                return;

            string error = "";

            TextBox textBox = sender as TextBox;
            int value;

            if (!int.TryParse(textBox.Text, out value))
            {
                e.Cancel = true;
                error = "Not a valid integer";
            }

            errorProvider.SetError(textBox, error);

        }

        //validate a non negative integer
        private void validateIntNoNegative(object sender, CancelEventArgs e)
        {
            if (!(sender is TextBox))
                return;

            string error = "";
            TextBox textBox = sender as TextBox;

            int value;
            if (!int.TryParse(textBox.Text, out value))
            {
                error = "Not a valid integer";
                e.Cancel = true;
            }

            if (value < 0)
            {
                e.Cancel = true;
                error = "Number must not be negative";
            }

            errorProvider.SetError(textBox, error);
        }

        //validate any float
        private void validateFloat(object sender, CancelEventArgs e)
        {
            if (!(sender is TextBox))
                return;

            string error = "";
            TextBox textBox = sender as TextBox;

            float value;
            if (!float.TryParse(textBox.Text, out value))
            {
                e.Cancel = true;
                error = "Not a valid floating point number";
            }

            errorProvider.SetError(textBox, error);
        }

        //validate combo box with only supplied options
        private void shapeCombo_Validating(object sender, CancelEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            string error = "";

            string item = box.SelectedItem as string;
            if (!(item == "Rectangle" ||
                item == "Ellipse" ||
                item == "Triangle"))
            {

                error = "Must choose a valid shape from the combobox";
                e.Cancel = true;
            }

            errorProvider.SetError(box, error);
        }


    }
}
