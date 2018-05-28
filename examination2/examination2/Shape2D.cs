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

        protected Shape2D(ShapeType shapeType, double length, double width)
            : base(shapeType)
        {
            Length = length;
            Width = width;
        }

        // ska vara abstract och inte någon implementation
        public abstract double Area
        {
            get;
        }
        
        public double Length // validera att värde inte är mindre än noll ska kasta undantag
        {
            get => _length;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("längd kan inte vara mindre än noll!");
                }
                else
                {
                    this._length = value;
                }
            }
        }

        public abstract double Perimeter
        {
            get;
        }

        public double Width // validera att värde inte är mindre än noll ska kasta undantag
        {
            get => _width;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("bredd kan inte vara mindre än noll!");
                }
                else
                {
                    this._width = value;
                }
            }
        }

        public override string ToString()
        {
            string returnString = "";
            returnString += "Längd : " + Length.ToString() + "\n";
            returnString += "Bredd : " + Width.ToString() + "\n";
            returnString += "Omkrets: " + Perimeter.ToString() + "\n";
            returnString += "Area : " + Area.ToString();

            return returnString;
        }

        public string ToString(string format)
        {
            if (format == "R")
            {
                return ShapeType.ToString() + " " + Math.Round(Length, 2).ToString() + " " + Math.Round(Width, 2).ToString() + " " + Math.Round(Perimeter, 2).ToString() + " " + Math.Round(Area, 2).ToString();
            }
            else if (format == "G" || format == "" || format == null)
            {
                return ToString();
            }
            else
            {
                throw new FormatException("Please use R, G, \"\" or null calling the ToSting method");
            }
        }
    }
}