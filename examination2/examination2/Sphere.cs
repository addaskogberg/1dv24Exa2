using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public class Sphere : Shape3D // KOLLA HUR JAG BER4ÄKNAR DE OLIKA VÄRDENA
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
                return Width *2;            
            }
            set
            {
                base.Width = value;
                base.Length = value;
                base.Height = value;
            }
        }

        public override double MantelArea
        {
            get => base._baseShape.Area*4;
        }

        public override double TotalSurfaceArea
        {
            get => MantelArea;
        }

        public override double Volume // BERÄKNA SEPARAT
        {
            get => base._baseShape.Area * base.Width * 4 / 3;
        }
    }
}