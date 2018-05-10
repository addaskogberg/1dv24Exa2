using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public class Sphere : Shape3D
    {
        public Sphere(double diameter)
            : base(ShapeType.Ellipse, new Ellipse(diameter), 0.0)
        {
            Diameter = diameter;
        }

        public double Diameter 
        {
            get
            {
                if (Width == Length)
                {
                    return Width + Length;
                }
                else
                {
                   return -1.0;
                }
            }
            set
            {
                base.Length = value;
                base.Height = value;
            }
        }

        public new double MantelArea
        {
            get => base.MantelArea;
        }

        public double TotalSurfaceAre
        {
            get => base.TotalSurfaceArea;
        }

        public new double Volume
        {
            get => base.Volume;
        }
    }
}