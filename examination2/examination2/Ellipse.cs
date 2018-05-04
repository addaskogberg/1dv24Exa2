using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public class Ellipse : Shape2D
    {
        public Ellipse(double diameter)
            :base(ShapeType.Ellipse, diameter, diameter)
        {
            // Detta är en cirkel
        }

        public Ellipse(double hdiameter, double vdiameter)
            : base(ShapeType.Ellipse, hdiameter, vdiameter)
        {

        }

        public new double Area
        {
            get => base.Area;
        }

        public new double Perimeter
        {
            get => base.Perimeter;
        }
    }
}