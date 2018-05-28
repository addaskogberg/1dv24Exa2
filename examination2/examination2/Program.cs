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
            Console.Read();
        }
    }
}
