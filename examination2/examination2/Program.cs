using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examination2 // ANVÄNDAREN SKA KUNNA VÄLJA ATT SLUMPA 2D ELLER 3D .... KOLLA DOKUMENTET. ANVÄNDAREN SKA KUNNA VÄLJA ANTINGEN 2D ELLER 3D OCH SEN SKA ANTAL SLUMPAS ÄVEN SLUMPA OM VILKEN FIGUR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*                    FIGURATIVT ARV                     *");
            Console.WriteLine("*********************************************************");
            Console.WriteLine();
            Console.WriteLine(" - Välj 2D- eller 3D-figurer genom att skriva \"2\" eller \"3\"");

            int figure = -1;
            bool falseinput = true;
            while (falseinput)
            {
                String figureString = Console.ReadLine();
                if (int.TryParse(figureString, out figure))
                {
                    if (figure < 2 || figure > 3)
                    {
                        Console.WriteLine("Skriv siffran 2 eller 3 och tryck [ENTER]");
                    }
                    else
                    {
                        falseinput = false;
                    }
                }
            }

            Random random = new Random();

            if (figure == 2)
            {
                List<Shape2D> shapes = new List<Shape2D>();
                for (int i = 0; i < 20; i++)
                {
                    int figure2D = random.Next(1, 4);
                    if(figure2D == 1)
                    {
                        shapes.Add(new Ellipse(random.NextDouble() * random.Next(1,101) ));
                    }
                    else if (figure2D == 2)
                    {
                        shapes.Add(new Ellipse(random.NextDouble() * random.Next(1, 101), random.NextDouble() * random.Next(1, 101)));
                    }
                    else
                    {
                        shapes.Add(new Rectangle(random.NextDouble() * random.Next(1, 101), random.NextDouble() * random.Next(1, 101) ));
                    }
                }

                List<Shape2D> sortedShapes = shapes.OrderBy(o => o.ShapeType).ThenBy(o => o.Area).ToList();

                Console.WriteLine("Figur     Längd  Bredd  Omkrets  Area");
                foreach (Shape2D shape in sortedShapes)
                {
                    Console.WriteLine(shape.ToString("R"));
                }
            }
            else
            {
                List<Shape3D> shapes = new List<Shape3D>();
                for (int i = 0; i < 20; i++)
                {
                    int figure3D = random.Next(1, 4);
                    if (figure3D == 1)
                    {
                        shapes.Add(new Cuboid(random.NextDouble() * random.Next(1, 101), random.NextDouble() * random.Next(1, 101), random.NextDouble() * random.Next(1, 101)));
                    }
                    else if (figure3D == 2)
                    {
                        shapes.Add(new Sphere(random.NextDouble() * random.Next(1, 101)));
                    }
                    else
                    {
                        shapes.Add(new Cylinder(random.NextDouble() * random.Next(1, 101), random.NextDouble() * random.Next(1, 101), random.NextDouble() * random.Next(1, 101)));
                    }
                }

                List<Shape3D> sortedShapes = shapes.OrderBy(o => o.ShapeType).ThenBy(o => o.Volume).ToList();

                Console.WriteLine("Figur     Längd  Bredd  Höjd  MantelArea, BegränsningsArea, Volym");
                foreach (Shape3D shape in sortedShapes)
                {
                    Console.WriteLine(shape.ToString("R"));
                }
            }


            /*
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
            */

            Console.Read();
        }
    }
}
