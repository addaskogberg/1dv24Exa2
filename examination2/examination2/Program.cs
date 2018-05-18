using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examination2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShapeType.Ellipse +":");
            Console.WriteLine("--------------");
            Ellipse ellipse = new Ellipse(10.0);
            Console.WriteLine(ellipse.ToString("R"));
            Console.WriteLine();

            Console.WriteLine(ShapeType.Rectangle + ":");
            Console.WriteLine("--------------");
            Rectangle rectangle = new Rectangle(12.2 , 10.0);
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine();

            Console.WriteLine(ShapeType.Cuboid + ":");
            Console.WriteLine("--------------");
            Cuboid cuboid = new Cuboid(2.0, 4.0, 3.0);
            Console.WriteLine(cuboid.ToString(null));
            Console.WriteLine();

            Console.WriteLine(ShapeType.Cylinder + ":");
            Console.WriteLine("--------------");
            Cylinder cylinder = new Cylinder(3.0, 2.0, 2.0);
            Console.WriteLine(cylinder.ToString("R"));
            Console.WriteLine();

            Console.WriteLine(ShapeType.Sphere + ":");
            Console.WriteLine("--------------");
            Sphere sphere = new Sphere(2.0);
            Console.WriteLine(sphere.ToString("G"));
            
            Console.Read();
        }
    }
}
