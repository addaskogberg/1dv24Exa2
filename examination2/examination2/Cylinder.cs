using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public class Cylinder : Shape3D
    {
        public Cylinder(double hdiameter, double vdiameter, double height)
            :base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), height)
        {
        }
    }
}