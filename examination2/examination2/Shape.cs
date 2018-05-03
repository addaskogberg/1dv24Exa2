using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public abstract class Shape
    {
        private readonly bool _is3D;

        protected Shape()
        {
            throw new System.NotImplementedException();
        }

        public bool Is3D => _is3D;

        public int ShapeType { get; set; }


        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}