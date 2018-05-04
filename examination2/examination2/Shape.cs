using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public abstract class Shape
    {
        private readonly bool _is3D;
 
        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }

        public bool Is3D => _is3D;

        public ShapeType ShapeType
        {
            get;
            private set;
        }

        public new string ToString()
        {
            return ShapeType.ToString();
        }
    }
}