using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Homework2
{
    class ShapeDoc
    {
        private HWShape shape;

        public ShapeDoc(ShapeEnum type)
        {
            shape = new HWShape(type);
        }

        public ShapeEnum Type {
            get { return shape.Type; }
            set { shape.Type = value; }
        }

        public string TypeText {
            get { return shape.TypeText; }
        }

        public HWShape Shape { get; set; }

        public void drawShapeOutline(Graphics g, Pen pen) { }

        public void drawShapeFill(Graphics g, Brush brush) { }
    }
}
