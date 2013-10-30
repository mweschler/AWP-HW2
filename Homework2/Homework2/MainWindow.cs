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
    public partial class MainWindow : BaseMainForm
    {
        private enum PenType { 
            SOLID,
            DASHED,
            COMPOUND
        }

        private OathDialog oathDlg = null;
        private AboutDialog aboutDlg = null;
        private ShapeEnum selectedType = ShapeEnum.RECTANGLE;
        private PenType selectedPen = PenType.SOLID;
        private Pen solidPen;
        private Pen dashedPen;
        private Pen compoundPen;

        public MainWindow()
        {
            InitializeComponent();
        }

        

        override protected void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oathDlg == null || oathDlg.IsDisposed)
            {
                oathDlg = new OathDialog();
                oathDlg.StartPosition = FormStartPosition.Manual;
                oathDlg.Location = new Point(this.Right, this.Top);
                oathDlg.Show(this);
            }
            else
                oathDlg.Activate();
        }

        override protected void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutDlg == null || aboutDlg.IsDisposed)
            {
                aboutDlg = new AboutDialog();
                aboutDlg.StartPosition = FormStartPosition.Manual;
                aboutDlg.Location = new Point(this.Left, this.Bottom);
                aboutDlg.Show(this);
            }
            else
                aboutDlg.Activate();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ToolStripManager.Merge(mainMenuExtend, mainMenuStrip);
            rectangleToolStripMenuItem.Checked = true;
            solidToolStripMenuItem.Checked = true;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedType = ShapeEnum.RECTANGLE;
            rectangleToolStripMenuItem.Checked = true;
            ellipseToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedType = ShapeEnum.ELLIPSE;
            ellipseToolStripMenuItem.Checked = true;
            rectangleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedType = ShapeEnum.TRIANGLE;
            triangleToolStripMenuItem.Checked = true;
            rectangleToolStripMenuItem.Checked = false;
            ellipseToolStripMenuItem.Checked = false;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedPen = PenType.SOLID;
            solidToolStripMenuItem.Checked = true;
            dashedToolStripMenuItem.Checked = false;
            compoundToolStripMenuItem.Checked = false;
        }

        private void dashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedPen = PenType.DASHED;
            dashedToolStripMenuItem.Checked = true;
            solidToolStripMenuItem.Checked = false;
            compoundToolStripMenuItem.Checked = false;

        }

        private void compoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedPen = PenType.COMPOUND;
            compoundToolStripMenuItem.Checked = true;
            solidToolStripMenuItem.Checked = false;
            dashedToolStripMenuItem.Checked = false;
        }

    }
}
