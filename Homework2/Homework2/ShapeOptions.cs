using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW1ContLib;

namespace Homework2
{
    public partial class ShapeOptions : BaseDialogBox, IShapeProperties
    {
        public ShapeOptions()
        {
            InitializeComponent();
        }

        public ShapeEnum Type;
        public Point Location;
        public Size Size;
        public Size Scale;
        public Point Translation;
        public float Rotation;


    }
}
