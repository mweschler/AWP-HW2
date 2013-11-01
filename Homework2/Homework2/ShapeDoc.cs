using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Homework2
{
    /// <summary>
    /// Represents a shape document
    /// </summary>
    class ShapeDoc
    {
        private HWShape shape;

        /// <summary>
        /// Initializes a new document of a type in at a location
        /// </summary>
        /// <param name="type">type of shape this document is for</param>
        /// <param name="location">location this shape exists at</param>
        public ShapeDoc(ShapeEnum type, Point location)
        {
            shape = new HWShape(type);
            shape.Location = location;
        }

        /// <summary>
        /// The type of shape in this document
        /// </summary>
        public ShapeEnum Type {
            get { return shape.Type; }
            set { shape.Type = value; }
        }

        /// <summary>
        /// The name of the shape in this document
        /// </summary>
        public string TypeText {
            get { return shape.TypeText; }
        }

        /// <summary>
        /// Draws the outline of the shape
        /// </summary>
        /// <param name="g">Graphics to draw with</param>
        /// <param name="pen">Pen to draw with</param>
        public void drawShapeOutline(Graphics g, Pen pen) {
            using (GraphicsPath path = new GraphicsPath())
            {
                switch (this.Type)
                {
                    case ShapeEnum.RECTANGLE:
                        path.AddRectangle(shape.Rectangle);
                        break;
                    case ShapeEnum.ELLIPSE:
                        path.AddEllipse(shape.Rectangle);
                        break;
                    case ShapeEnum.TRIANGLE:
                        path.AddPolygon(shape.TrianglePoints);
                        break;
                }
                path.Transform(shape.Transformation);
                g.DrawPath(pen, path);
            }
        }

        /// <summary>
        /// Draws the fill for this shape
        /// </summary>
        /// <param name="g">Graphics to draw with</param>
        /// <param name="brush">Brush to draw with</param>
        public void drawShapeFill(Graphics g, Brush brush) {
            //Console.WriteLine("Drawing Shape Fill");

            if (shape.Size.Width == 0 || shape.Size.Height == 0)
                return;

            //if brush is graident, use a similar brush with correct rectangle/transform
            if (brush is LinearGradientBrush)
            {
                Color[] colors = (brush as LinearGradientBrush).LinearColors;

                LinearGradientBrush grad = new LinearGradientBrush(
                    shape.Rectangle, colors[0], colors[1], 0f);

                grad.Transform = shape.Transformation;
                brush = grad;
            }

            using (GraphicsPath path = new GraphicsPath())
            {
                switch (this.Type)
                {
                    case ShapeEnum.RECTANGLE:
                        path.AddRectangle(shape.Rectangle);
                        break;
                    case ShapeEnum.ELLIPSE:
                        path.AddEllipse(shape.Rectangle);
                        break;
                    case ShapeEnum.TRIANGLE:
                        path.AddPolygon(shape.TrianglePoints);
                        break;
                }
                path.Transform(shape.Transformation);

                g.FillPath(brush, path);
            }
        }

        /// <summary>
        /// Update the shape size using supplied point and current location
        /// </summary>
        /// <param name="point">point update from</param>
        public void updateShape(Point point) {
            int width = point.X - shape.Location.X;
            int height = point.Y - shape.Location.Y;

            shape.Size = new Size(width, height);
        }

        /// <summary>
        /// Tells if the point is within the shape
        /// </summary>
        /// <param name="point">point to test</param>
        /// <param name="pen">pen used to outline shape</param>
        /// <returns>true if point is within shape bounds</returns>
        public bool inShape(Point point, Pen pen)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                switch (this.Type)
                {
                    case ShapeEnum.RECTANGLE:
                        path.AddRectangle(shape.Rectangle);
                        break;
                    case ShapeEnum.ELLIPSE:
                        path.AddEllipse(shape.Rectangle);
                        break;
                    case ShapeEnum.TRIANGLE:
                        path.AddPolygon(shape.TrianglePoints);
                        break;
                }

                path.Transform(shape.Transformation);

                //test shape interior first
                if (path.IsVisible(point))
                    return true;

                //adjust path to pen and test if point lies on pen line
                path.Widen(pen);
                return path.IsVisible(point);
            }
        }

        /// <summary>
        /// Fills the given properties with the shape's values
        /// </summary>
        /// <param name="properties">properties to fill</param>
        public void fillProperties(IShapeProperties properties)
        {
            shape.fillProperties(properties);
        }

        /// <summary>
        /// Updates the shapes values from the given properties
        /// </summary>
        /// <param name="properties">properties to pull values from</param>
        public void updateFromProperties(IShapeProperties properties)
        {
            shape.updateFromProperties(properties);
        }
    }
}
