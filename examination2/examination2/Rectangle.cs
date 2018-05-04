using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public class Rectangle : Shape2D
    {
        public Rectangle(double length, double width)
            :base(ShapeType.Rectangle, length, width)
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