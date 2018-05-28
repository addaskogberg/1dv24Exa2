using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination2
{
    public abstract class Shape3D : Shape // SAMTLIGA SKA VARA READONLY KOLLA ALLA BERÄKNINGAR
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("´höjden kan inte vara mindre än noll!");
                }
                else
                {
                    this._height = value;
                }
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

        public virtual double MantelArea
        {
            get 
            {
                    return _baseShape.Perimeter * 4; 
            }
        }

        public virtual double TotalSurfaceArea
        {
            get
            {
                    return _baseShape.Area * 2 + MantelArea;
            }

        }

        public double Width // validera att höjden inte är mindre än noll
        {
            get => _baseShape.Width;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("längd kan inte vara mindre än noll!");
                }
                else
                {
                    this._baseShape.Width = value;
                }
            }
        }

        public virtual double Volume
        {
            get
            {
                return _baseShape.Area * _height;
            }
 
        }

        public override string ToString()
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

        public string ToString(string format)
        {
            if (format == "R")
            {
                return ShapeType.ToString() + " " + Math.Round(Length, 2).ToString() + " " + Math.Round(Width, 2).ToString() + " " + Math.Round(Height, 2).ToString() + " " +
                    Math.Round(MantelArea, 2).ToString() + " " + Math.Round(TotalSurfaceArea, 2).ToString() + " " + Math.Round(Volume, 2).ToString();
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