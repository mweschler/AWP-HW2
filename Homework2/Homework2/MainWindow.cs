using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using HWContLib;

namespace Homework2
{
    public partial class MainWindow : BaseMainForm
    {
        private OathDialog oathDlg = null;
        private AboutDialog aboutDlg = null;

        private ShapeEnum selectedType = ShapeEnum.RECTANGLE;

        private Pen selectedPen;
        private Pen solidPen;
        private Pen dashedPen;
        private Pen compoundPen;

        private Brush selectedBrush;
        private Brush solidBrush;
        private Brush hatchedBrush;
        private Brush gradientBrush;

        private Color penColor = Color.Black;
        private Color brushColor = Color.Red;

        public MainWindow()
        {
            InitializeComponent();
            solidPen = new Pen(penColor, 3);
            
            dashedPen = new Pen(penColor, 3);
            dashedPen.DashPattern = new float[] { 1.0f, 1.0f, 4.0f, 3.0f, 2.0f};
            dashedPen.DashStyle = DashStyle.Custom;

            compoundPen = new Pen(penColor, 3);
            compoundPen.CompoundArray = new float[] { 0.0f, 0.3f, 0.45f, 0.55f, 0.7f, 1.0f};
            
            selectedPen = solidPen;

            solidBrush = new SolidBrush(brushColor);
            hatchedBrush = new HatchBrush(HatchStyle.BackwardDiagonal, brushColor);
            gradientBrush = new LinearGradientBrush(new Rectangle(0, 0, 10, 10), penColor, brushColor, 0.45f);
            selectedBrush = solidBrush;
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
            solidPenToolStripMenuItem.Checked = true;
            solidBrushToolStripMenuItem.Checked = true;
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
            this.selectedPen = solidPen;
            solidPenToolStripMenuItem.Checked = true;
            dashedToolStripMenuItem.Checked = false;
            compoundToolStripMenuItem.Checked = false;
        }

        private void dashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedPen = dashedPen;
            dashedToolStripMenuItem.Checked = true;
            solidPenToolStripMenuItem.Checked = false;
            compoundToolStripMenuItem.Checked = false;

        }

        private void compoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedPen = compoundPen;
            compoundToolStripMenuItem.Checked = true;
            solidPenToolStripMenuItem.Checked = false;
            dashedToolStripMenuItem.Checked = false;
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedBrush = hatchedBrush;
            hatchToolStripMenuItem.Checked = true;
            solidBrushToolStripMenuItem.Checked = false;
            gradientToolStripMenuItem.Checked = false;
        }

        private void gradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedBrush = gradientBrush;
            gradientToolStripMenuItem.Checked = true;
            solidBrushToolStripMenuItem.Checked = false;
            hatchToolStripMenuItem.Checked = false;
        }

        private void solidBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedBrush = solidBrush;
            solidBrushToolStripMenuItem.Checked = true;
            gradientToolStripMenuItem.Checked = false;
            hatchToolStripMenuItem.Checked = false;
        }

    }
}
