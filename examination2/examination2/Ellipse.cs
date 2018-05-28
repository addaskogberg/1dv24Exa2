using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{ // ´här ska  beräkningar för area och omkrets ligga

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
        
        public override double Area
        {
            get => Math.PI * base.Length * base.Width;
        }

        public override double Perimeter
        {
            get =>  Math.Sqrt(Math.Pow(base.Length, 2)*2 + Math.Pow(base.Width, 2)*2)*Math.PI ;
        }
    }
}