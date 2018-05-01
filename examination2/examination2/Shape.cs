using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public abstract class Shape
    {
        protected Shape()
        {
            throw new System.NotImplementedException();
        }

        public readonly bool Is3D
        {
            get => default(int);
            set
            {
            }
        }

        public int ShapeType
        {
            get => default(int);
            set
            {
            }
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}