﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public class Cuboid : Shape3D
    {
        public Cuboid(double length, double width, double height)
            :base(ShapeType.Cuboid, new Rectangle(length, width), height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
    }
}