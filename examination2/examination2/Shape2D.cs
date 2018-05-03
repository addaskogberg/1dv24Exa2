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
            get
            {
                if (Rectangle)
                {
                    return  _length * _width;
                }
                else
                {
                    return Math.PI *_length * _width;
                }

            }

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
                    return 2 * _length + 2 + _width ;
                } 
                else
                {
                    return Math.Sqrt(Math.Pow(_length, 2)*2 + Math.Pow(_width, 2)*2)*Math.PI ;
                }

            }
           
        }

        public double Width
        {
            get => _width;

            set => _width = value;
        }

        public new string ToString()
        {
            string returnString = "";
            returnString += "Längd : " + Length.ToString() + "\n";
            returnString += "Bredd : " + Width.ToString() + "\n";
            returnString += "Omkrets: " + Perimeter.ToString() + "\n";
            returnString += "Area : " + Area.ToString();

            return returnString;
        }

        public string ToString(string format) => "Ellipse " + Length.ToString() + " " + Width.ToString() + " " + Perimeter.ToString() + " " + Area.ToString();
    }
}