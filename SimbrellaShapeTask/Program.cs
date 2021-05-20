using SimbrellaShapeTask.Methods;
using SimbrellaShapeTask.Models;
using System;
using System.Collections;

namespace SimbrellaShapeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //Circle circle = new Circle(random.Next(1,5) );
            //Console.WriteLine(circle.GetArea());

            //Rectangle rectangle = new Rectangle(random.Next(1, 5), random.Next(3, 5));
            //Console.WriteLine(rectangle.GetArea());

            //Triangle triangle = new Triangle(5, 4, 3);
            //Console.WriteLine(triangle.GetArea());

            //Sphere sphere = new Sphere(5);
            //Console.WriteLine(sphere.GetArea());
            //Console.WriteLine(sphere.GetVolume());

            //Cube cube = new Cube(3);
            //Console.WriteLine(cube.GetArea());
            //Console.WriteLine(cube.GetVolume());

            //Tetrahedron tetrahedron  = new Tetrahedron(3);
            //Console.WriteLine(tetrahedron.GetArea());
            //Console.WriteLine(tetrahedron.GetVolume());

            var arlist = new ArrayList();

            for (int i = 0; i < 15; i++)
            {
                if (i %2 == 0)
                {
                   arlist.Add(Utilities.GetTwoDShape());
                    continue;
                }
              
                   arlist.Add(Utilities.GetThreeDShape());
                
            }
            int counter = 1;
            foreach (var item in arlist)
            {
               
                Console.WriteLine($"Shape [{counter++}] = {item}");
            }






            Console.ReadLine();
        }
    }
}
