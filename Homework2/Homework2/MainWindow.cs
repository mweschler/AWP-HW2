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
using System.IO;
using HWContLib;

namespace Homework2
{
    public partial class MainWindow : BaseMainForm
    {
        private OathDialog oathDlg = null;
        private AboutDialog aboutDlg = null;
        private ToolStripStatusLabel statusLabel = new ToolStripStatusLabel();

        private ShapeEnum selectedType = ShapeEnum.RECTANGLE;

        private Pen selectedPen;
        private Pen solidPen;
        private Pen dashedPen;
        private Pen compoundPen;

        private Brush selectedBrush;
        private SolidBrush solidBrush;
        private HatchBrush hatchedBrush;
        private LinearGradientBrush gradientBrush;

        private Color penColor = Color.Black;
        private Color brushColor = Color.Red;

        private bool isDrawing = false;
        private Point mouseStart;
        private ShapeDoc drawDoc = null;
        private ShapeDoc selectedShape = null;

        private List<ShapeDoc> documents = new List<ShapeDoc>();

        private ShapeOptions optionsDlg = null;

        public MainWindow()
        {
            
            InitializeComponent();

            //initialize the pens
            solidPen = new Pen(penColor, 5);
            
            dashedPen = new Pen(penColor, 5);
            dashedPen.DashPattern = new float[] { 1.0f, 1.0f, 4.0f, 3.0f, 2.0f};
            dashedPen.DashStyle = DashStyle.Custom;

            compoundPen = new Pen(penColor, 10);
            compoundPen.CompoundArray = new float[] { 0.0f, 0.3f, 0.45f, 0.55f, 0.7f, 1.0f};
            
            selectedPen = solidPen;

            //intialize the brushes
            solidBrush = new SolidBrush(brushColor);
            hatchedBrush = new HatchBrush(HatchStyle.Weave, brushColor);
            gradientBrush = new LinearGradientBrush(new Rectangle(0, 0, 10, 10), penColor, brushColor, 0f);
            selectedBrush = solidBrush;

            //setup the status label
            this.mainStatusStrip.Items.Add(statusLabel);
            statusLabel.Spring = true;
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            updateStausText();
        }

        /// <summary>
        /// Updates the status strip label with the current state
        /// </summary>
        private void updateStausText() 
        {
            using (StringWriter sw = new StringWriter()) 
            {
                //Shape
                sw.Write("Shape [");
                switch (selectedType)
                {
                    case ShapeEnum.RECTANGLE: sw.Write("Rectangle"); break;
                    case ShapeEnum.ELLIPSE: sw.Write("Ellipse"); break;
                    case ShapeEnum.TRIANGLE: sw.Write("Triangle"); break;
                }

                //Pen
                sw.Write("] | Pen  [");
                if(selectedPen.Equals(solidPen))
                    sw.Write("Solid");
                if(selectedPen.Equals(dashedPen))
                    sw.Write("Dashed");
                if (selectedPen.Equals(compoundPen))
                    sw.Write("Compund");

                sw.Write("] Pen ");
                sw.Write(penColor);
                
                //Brush
                sw.Write(" | Brush [");

                if (selectedBrush is SolidBrush)
                    sw.Write("Solid");
                if (selectedBrush is HatchBrush)
                    sw.Write("Hatched");
                if (selectedBrush is LinearGradientBrush)
                    sw.Write("Gradient");

                sw.Write("] Brush ");
                sw.Write(brushColor);

                this.statusLabel.Text = sw.ToString();
            }
        }

        //show oath dialog
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

        //show about dialog
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

            //set the initial states for menus/toolbars
            rectangleToolStripMenuItem.Checked = true;
            solidPenToolStripMenuItem.Checked = true;
            solidBrushToolStripMenuItem.Checked = true;
            rectButton.Checked = true;
            solidPenButton.Checked = true;
            solidBrushButton.Checked = true;
        }

        //rectangle menu/button pressed
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedType = ShapeEnum.RECTANGLE;

            rectangleToolStripMenuItem.Checked = true;
            ellipseToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;

            rectButton.Checked = true;
            ellipseButton.Checked = false;
            triangleButton.Checked = false;

            updateStausText();

            mainPanel.Invalidate();
        }

        //ellipse menu/button pressed
        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedType = ShapeEnum.ELLIPSE;

            ellipseToolStripMenuItem.Checked = true;
            rectangleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;

            ellipseButton.Checked = true;
            rectButton.Checked = false;
            triangleButton.Checked = false;

            updateStausText();

            mainPanel.Invalidate();
        }

        //triangle menu/button pressed
        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedType = ShapeEnum.TRIANGLE;

            triangleToolStripMenuItem.Checked = true;
            rectangleToolStripMenuItem.Checked = false;
            ellipseToolStripMenuItem.Checked = false;

            triangleButton.Checked = true;
            rectButton.Checked = false;
            ellipseButton.Checked = false;

            updateStausText();

            mainPanel.Invalidate();
        }

        //solid pen menu/button pressed
        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedPen = solidPen;

            solidPenToolStripMenuItem.Checked = true;
            dashedToolStripMenuItem.Checked = false;
            compoundToolStripMenuItem.Checked = false;

            solidPenButton.Checked = true;
            dashedPenButton.Checked = false;
            compundPenButton.Checked = false;

            updateStausText();

            mainPanel.Invalidate();
        }

        //dashed pen menu/button pressed
        private void dashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedPen = dashedPen;

            dashedToolStripMenuItem.Checked = true;
            solidPenToolStripMenuItem.Checked = false;
            compoundToolStripMenuItem.Checked = false;

            dashedPenButton.Checked = true;
            solidPenButton.Checked = false;
            compundPenButton.Checked = false;

            updateStausText();

            mainPanel.Invalidate();

        }

        //compound pen button/menu pressed
        private void compoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedPen = compoundPen;

            compoundToolStripMenuItem.Checked = true;
            solidPenToolStripMenuItem.Checked = false;
            dashedToolStripMenuItem.Checked = false;

            compundPenButton.Checked = true;
            solidPenButton.Checked = false;
            dashedPenButton.Checked = false;

            updateStausText();

            mainPanel.Invalidate();
        }

        //hatch brush menu/button pressed
        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedBrush = hatchedBrush;

            hatchToolStripMenuItem.Checked = true;
            solidBrushToolStripMenuItem.Checked = false;
            gradientToolStripMenuItem.Checked = false;

            hatchedBrushButton.Checked = true;
            solidBrushButton.Checked = false;
            gradientBrushButton.Checked = false;

            updateStausText();

            mainPanel.Invalidate();
        }

        //gradient menu/button pressed
        private void gradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedBrush = gradientBrush;

            gradientToolStripMenuItem.Checked = true;
            solidBrushToolStripMenuItem.Checked = false;
            hatchToolStripMenuItem.Checked = false;

            gradientBrushButton.Checked = true;
            solidBrushButton.Checked = false;
            hatchedBrushButton.Checked = false;

            updateStausText();

            mainPanel.Invalidate();
        }

        //solid brush menu/button pressed
        private void solidBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedBrush = solidBrush;

            solidBrushToolStripMenuItem.Checked = true;
            gradientToolStripMenuItem.Checked = false;
            hatchToolStripMenuItem.Checked = false;

            solidBrushButton.Checked = true;
            hatchedBrushButton.Checked = false;
            gradientBrushButton.Checked = false;

            updateStausText();

            mainPanel.Invalidate();
        }

        /// <summary>
        /// Gets a new color value via a color dialog
        /// </summary>
        /// <param name="startcolor">initial value of the dialog</param>
        /// <returns>color picked or previous color on cancel</returns>
        private static Color getColor(Color startcolor)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = startcolor;
                if (dlg.ShowDialog() == DialogResult.OK)
                    return dlg.Color;
               
                return startcolor;
            }
        }

        //pen color menu/button pressed
        private void setPenColor(object sender, EventArgs e)
        {
            penColor = getColor(penColor);

            solidPen.Color = penColor;
            dashedPen.Color = penColor;
            compoundPen.Color = penColor;

            //update the graident brush as well as it uses pen color
            gradientBrush.LinearColors = new Color[] { penColor, brushColor };

            //make a new hatched brush to use pen color, cannot set once constructed
            hatchedBrush.Dispose();
            hatchedBrush = new HatchBrush(HatchStyle.Weave, penColor, brushColor);
            if (selectedBrush is HatchBrush)
                selectedBrush = hatchedBrush;

            updateStausText();

            mainPanel.Invalidate();
        }

        //brush color menu/button pressed
        private void setBrushColor(object sender, EventArgs e)
        {
            brushColor = getColor(brushColor);

            solidBrush.Color = brushColor;

            //make a new hatch brush as you can only set colors once
            hatchedBrush.Dispose();
            hatchedBrush = new HatchBrush(HatchStyle.Weave, penColor, brushColor);
            if (selectedBrush is HatchBrush)
                selectedBrush = hatchedBrush;

            gradientBrush.LinearColors = new Color[] { penColor, brushColor };

            updateStausText();

            mainPanel.Invalidate();
        }

        //mouse down on main panel
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //initialize drawing mode
            if (e.Button == MouseButtons.Left && !isDrawing)
            {
                isDrawing = true;
                mouseStart = new Point(e.X, e.Y);
                drawDoc = new ShapeDoc(selectedType, mouseStart);                
            }

            //open the properties on right click
            if (e.Button == MouseButtons.Right) 
            {
                ShapeDoc foundShape = null;

                //find a shape in the click location
                foreach (ShapeDoc doc in documents)
                {
                    if (doc.inShape(new Point(e.X, e.Y), selectedPen))
                    {
                        foundShape = doc;
                        break;
                    }
                }

                if (foundShape == null)
                    return;

                selectedShape = foundShape;

                //open the dialog if not already open, if open change the properties
                if (optionsDlg == null || optionsDlg.IsDisposed)
                {
                    optionsDlg = new ShapeOptions();
                    optionsDlg.Apply += new EventHandler(applyOptions);
                    optionsDlg.StartPosition = FormStartPosition.Manual;
                    optionsDlg.Top = this.Top;
                    optionsDlg.Left = this.Right;
                    optionsDlg.Show(this);
                }

                selectedShape.fillProperties(optionsDlg);
            }
        }

        //apply properties
        private void applyOptions(object sender, EventArgs e) 
        {
            selectedShape.updateFromProperties(optionsDlg);
            mainPanel.Invalidate();
        }

        //mouse has moved
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //update the drawing shape if moved while drawing
            if (isDrawing)
            {
                drawDoc.updateShape(new Point(e.X, e.Y));
                mainPanel.Invalidate();
            }
        }

        //mouse buttone released
        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            //if was drawing, update shape last time then add to list of documents
            if (isDrawing && e.Button == MouseButtons.Left) 
            {
                isDrawing = false;

                drawDoc.updateShape(new Point(e.X, e.Y));

                documents.Add(drawDoc);
                drawDoc = null;

                mainPanel.Invalidate();
            }
        }

        //draw the documents and the drawing doc
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            
            foreach (ShapeDoc doc in documents) 
            {
                doc.drawShapeFill(e.Graphics, selectedBrush);
                doc.drawShapeOutline(e.Graphics, selectedPen);
            }

            if (drawDoc != null)
            {
                drawDoc.drawShapeFill(e.Graphics, selectedBrush);
                drawDoc.drawShapeOutline(e.Graphics, selectedPen);
            }
        }
    }
}
