using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW1ContLib
{
    public partial class Oathbox : UserControl
    {
        public Oathbox()
        {
            InitializeComponent();
        }

        private void Oathbox_Load(object sender, EventArgs e)
        {
            if (this.Parent != null) {
                this.BackColor = this.Parent.BackColor;
                this.BackgroundImage = this.Parent.BackgroundImage;
            }
        }
    }
}
