using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW1ContLib
{
    public interface IShapeColor { 
        Color Color{get; set;}
        event EventHandler ColorUpdated;
    }

    public partial class BaseShapeForm : Form, IShapeColor
    {
        Point mouseStart;

        public event EventHandler ColorUpdated;

        protected float ratio = 0.0f;

        public Color Color {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public BaseShapeForm() {
            InitializeComponent();
            this.mouseStart = Point.Empty;
        }

        public BaseShapeForm(float ratio)
        {
            InitializeComponent();
            this.ratio = ratio;
            mouseStart = Point.Empty;
            
        }

        private void baseform_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                mouseStart = new Point(e.X, e.Y);
            }
        }

        private void baseform_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseStart != Point.Empty) {
                
                Point delta = new Point(e.X - mouseStart.X, e.Y - mouseStart.Y);
                this.Location = new Point(this.Left + delta.X, this.Top + delta.Y);             
            }
        }

        private void baseform_MouseUp(object sender, MouseEventArgs e)
        {
            mouseStart = Point.Empty;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = this.BackColor;
                if (DialogResult.OK == dlg.ShowDialog())
                {
                    this.BackColor = dlg.Color;
                    ColorUpdated(this, EventArgs.Empty);
                }
            }
        }

        private void closeChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
