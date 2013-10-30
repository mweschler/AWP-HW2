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
        private ShapeEnum type;
        private Point location;
        private Size size;
        private Size scale;
        private Point translation;
        private float rotation;

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
                return typeToString(this.type);
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
        public Size Scale { get; set; }

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
                transform.Rotate(Rotation);

                return transform;
            }
        }
        
        /// <summary>
        /// Initializes a new shape of the supplied type
        /// </summary>
        /// <param name="type">Type of shape to initialize</param>
        HWShape(ShapeEnum type) 
        {
            this.Type = type;
            this.Location = new Point(0, 0);
            this.Size = new Size(0, 0);
            this.Scale = new Size(1, 1);
            this.Translation = new Point(0, 0);
            this.Rotation = 0.0f;
        }

        public HWShape(ShapeEnum type)
        {
            // TODO: Complete member initialization
            this.type = type;
        }

        public static string typeToString(ShapeEnum type){
            switch (type) 
                {
                    case ShapeEnum.ELLIPSE: return "Ellipse";
                    case ShapeEnum.RECTANGLE: return "Rectangle";
                    case ShapeEnum.TRIANGLE: return "Triangle";
                    default: return "Not set";
                } 
        }

    }
}
