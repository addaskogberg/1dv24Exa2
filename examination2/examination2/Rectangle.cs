﻿using System;
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

        public override double Area
        {
            get => base.Length * base.Width;
        }

        public override double Perimeter
        {
            get => 2 * base.Length + 2 * base.Width;
        }
    }
}


