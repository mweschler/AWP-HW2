using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Homework2
{
    interface IShapeProperties
    {
        public ShapeEnum Type;
        public Point Location;
        public Size Size;
        public Size Scale;
        public Point Translation;
        public float Rotation;
    }
}
