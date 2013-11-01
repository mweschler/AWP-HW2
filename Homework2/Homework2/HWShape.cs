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
    /// Represents a shape used in HW2 Drawing
    /// </summary>
    class HWShape
    {

        /// <summary>
        /// The type of shape
        /// </summary>
        public ShapeEnum Type { get; set; }

        /// <summary>
        /// The type of shape as a string
        /// </summary>
        public string TypeText
        {
            get {
                return typeToString(this.Type);
            }
        }

        /// <summary>
        /// The location of the shape
        /// </summary>
        public Point Location { get; set; }

        /// <summary>
        /// The size of the shape
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// The height/width scaling of the shape
        /// </summary>
        public SizeF Scale { get; set; }

        /// <summary>
        /// The translation of the shape
        /// </summary>
        public Point Translation { get; set; }

        /// <summary>
        /// The rotation of the shape
        /// </summary>
        public float Rotation { get; set; }

        /// <summary>
        /// The transfromation matrix for this shape
        /// </summary>
        public Matrix Transformation
        {
            get 
            {
                Matrix transform = new Matrix();

                transform.Translate(Translation.X, Translation.Y);
                transform.Scale(Scale.Width, Scale.Height);

                //rotate around the center of this object
                PointF rotationPoint = new PointF(Location.X + (Size.Width / 2.0f), 
                    Location.Y + (Size.Height / 2.0f));
                transform.RotateAt(Rotation, rotationPoint);  

                return transform;
            }
        }

        /// <summary>
        /// Gets a rectangle bounds of this shape
        /// </summary>
        public Rectangle Rectangle
        {
            get
            {
                Rectangle rect = new Rectangle(this.Location, this.Size);

                //if the width or height is negative make the location the upper left most point
                if (this.Size.Width < 0)
                {
                    Point loc = rect.Location;
                    loc.X = loc.X + rect.Size.Width;
                    rect.Location = loc;

                    Size size = rect.Size;
                    size.Width = Math.Abs(size.Width);
                    rect.Size = size;
                }

                if (this.Size.Height < 0)
                {
                    Point loc = rect.Location;
                    loc.Y = loc.Y + rect.Size.Height;
                    rect.Location = loc;

                    Size size = rect.Size;
                    size.Height = Math.Abs(size.Height);
                    rect.Size = size;
                }

                return rect;
            }
        }

        /// <summary>
        /// Gets the points for a triangle of this shape
        /// </summary>
        public Point[] TrianglePoints {
            get
            {
                return (new Point[] {this.Location,
                        new Point(this.Location.X, this.Location.Y + this.Size.Height),
                        new Point(this.Location.X + this.Size.Width,
                            this.Location.Y + this.Size.Height)
                    });
            }
        }
        
        /// <summary>
        /// Initializes a new shape of the supplied type
        /// </summary>
        /// <param name="type">Type of shape to initialize</param>
        public HWShape(ShapeEnum type) 
        {
            this.Type = type;
            this.Location = new Point(0, 0);
            this.Size = new Size(0, 0);
            this.Scale = new Size(1, 1);
            this.Translation = new Point(0, 0);
            this.Rotation = 0.0f;
        }

        
        /// <summary>
        /// Converts a type to a string
        /// </summary>
        /// <param name="type">type to convert</param>
        /// <returns>string for the type</returns>
        public static string typeToString(ShapeEnum type){
            switch (type) 
                {
                    case ShapeEnum.ELLIPSE: return "Ellipse";
                    case ShapeEnum.RECTANGLE: return "Rectangle";
                    case ShapeEnum.TRIANGLE: return "Triangle";
                    default: return "Not set";//should never be true
                } 
        }

        /// <summary>
        /// Converts a string to the type enumeration
        /// </summary>
        /// <param name="value">string to convert</param>
        /// <returns>type the string represents</returns>
        public static ShapeEnum stringToType(string value) {
            if (value.ToUpper().CompareTo("ELLIPSE") == 0)
                return ShapeEnum.ELLIPSE;
            if (value.ToUpper().CompareTo("RECTANGLE") == 0)
                return ShapeEnum.RECTANGLE;
            if (value.ToUpper().CompareTo("TRIANGLE") == 0)
                return ShapeEnum.TRIANGLE;

            //only accept correct arguments
            throw new ArgumentException("String was not a ELLIPSE, RECTANGLE, or TRIANGLE");
        }

        /// <summary>
        /// Fills a supplied properties with the values from this shape
        /// </summary>
        /// <param name="properties">Properties to fill</param>
        public void fillProperties(IShapeProperties properties)
        {
            properties.ShapeLocation = this.Location;
            properties.ShapeRotation = this.Rotation;
            properties.ShapeScale = this.Scale;
            properties.ShapeSize = this.Size;
            properties.ShapeTranslation = this.Translation;
            properties.ShapeType = this.Type;
        }

        /// <summary>
        /// Sets this shape's values to the ones supplied in the properties
        /// </summary>
        /// <param name="properties">the properties to set from</param>
        public void updateFromProperties(IShapeProperties properties)
        {
            this.Location = properties.ShapeLocation;
            this.Rotation = properties.ShapeRotation;
            this.Scale = properties.ShapeScale;
            this.Size = properties.ShapeSize;
            this.Translation = properties.ShapeTranslation;
            this.Type = properties.ShapeType;
        }

    }
}
