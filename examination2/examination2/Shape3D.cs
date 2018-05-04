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
     
        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height)
            : base(shapeType)
        {
            _baseShape = baseShape;
            _height = height;
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public double Length
        {
            get
            {
                return _baseShape.Length;
            }
            set
            {
                _baseShape.Length = value;
            }
        }

        public double MantelArea
        {
            get 
            {
                if (base.ShapeType == ShapeType.Sphere)
                {
                    return _baseShape.Area * 4;
                }
                else 
                {
                    return _baseShape.Perimeter * 4;
                }
               
            }
        }

        public double TotalSurfaceArea
        {
            get
            {
                if (base.ShapeType == ShapeType.Sphere)
                {
                    return _baseShape.Area * 4;
                }
                else
                {
                    return MantelArea + (2 * _baseShape.Area);
                }

            }

        }

        public double Width
        {
            get
            {
                return _baseShape.Width;
            }
            set
            {
                _baseShape.Width = value;
            }
        }

        public double Volume
        {
            get
            {
                return _baseShape.Area * _height;
            }
            set
            {
                Volume = value;
            }
        }

        public new string ToString()
        {
            string returnString = "";
            returnString += "Längd : " + Length.ToString() + "\n";
            returnString += "Bredd : " + Width.ToString() + "\n";
            returnString += "Höjd : " + Height.ToString() + "\n";
            returnString += "Mantelarea :" + MantelArea.ToString() + "\n";
            returnString += "Begränsningsarea: " + TotalSurfaceArea.ToString() + "\n";
            returnString += "Volym : " + Volume.ToString();

            return returnString;
        }

        public string ToString(string format) => ShapeType.ToString() + Length.ToString() + " " + Width.ToString() + " " + Height.ToString() + " " +
                MantelArea.ToString() + " " + TotalSurfaceArea.ToString() + " " + Volume.ToString();
    }
}