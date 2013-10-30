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
        ShapeEnum ShapeType {get; set;}
        Point ShapeLocation {get; set;}
        Size ShapeSize { get; set; }
        SizeF ShapeScale { get; set; }
        Point ShapeTranslation { get; set; }
        float ShapeRotation { get; set; }
    }
}
