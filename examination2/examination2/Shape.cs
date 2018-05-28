using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public abstract class Shape
    {
        private readonly bool _is3D;
        private ShapeType shapeType;
 
        protected Shape(ShapeType shapeType) 
        {
            ShapeType = shapeType;
        }

        public ShapeType ShapeType 
        {
            get
            {
                return shapeType;
            }
            private set
            {
                this.shapeType = value;
            }   
        }

        
        public bool Is3D
        {
            get
            {
                if (ShapeType == ShapeType.Cuboid || ShapeType == ShapeType.Cylinder || ShapeType == ShapeType.Sphere)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public abstract override string ToString();
    }
}