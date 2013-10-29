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
    public partial class BaseMainForm : Form
    {
        public BaseMainForm()
        {
            InitializeComponent();
        }

        virtual protected void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException("The Oath menu item has not been implemented");
        }

        virtual protected void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException("The About menu itme has not been implemented");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
