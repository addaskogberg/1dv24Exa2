using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public abstract class Shape2D : Shape
    {
        private double _length;
        private double _width;

        protected Shape2D(string shapeType, double length, double width)
        {
            throw new System.NotImplementedException();
        }

        public double Area
        {
            get => Length * Width;

        }

        public double Length
        {
            get => _length;

            set => _length = value;
        }

        public double Perimeter
        {
            get
            {
                if (Rectangle)
                {
                    return ;
                }
                else
                {
                    return ;
                }

            }
           
        }

        public double Width
        {
            get
            {
                return this._width;
            }
            set
            {
            }
        }

        public string ToString()
        {
            throw new System.NotImplementedException();
        }

        public string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}