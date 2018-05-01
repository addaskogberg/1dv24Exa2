using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public abstract class Shape3D : Shape
    {
        protected Shape2D _baseShape;
        protected double _height;

        public Shape3D()
        {
            throw new System.NotImplementedException();
        }

        public double Height
        {
            get => default(int);
            set
            {
            }
        }

        public double Length
        {
            get => default(int);
            set
            {
            }
        }

        public double MantelArea
        {
            get => default(int);
            set
            {
            }
        }

        public double TotalSurfaceArea
        {
            get => default(int);
            set
            {
            }
        }

        public double Width
        {
            get => default(int);
            set
            {
            }
        }

        public double Volume
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

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}