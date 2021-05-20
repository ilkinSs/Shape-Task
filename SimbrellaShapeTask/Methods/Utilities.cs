using SimbrellaShapeTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbrellaShapeTask.Methods
{
    static class Utilities
    {
        public static TwoDShape GetTwoDShape()
        {
            Random random = new Random();

            int countOfSides = random.Next(1, 4);

            if (countOfSides == 1)
            {

                Circle circle = new Circle(random.Next(1, 10));

                return circle;
            }

            if (countOfSides == 2)
            {

                Rectangle rectangle = new Rectangle(random.Next(1, 10));

                return rectangle;
            }

           

                Triangle triangle = new Triangle(random.Next(1, 10));

                return triangle;
            



        }

        public static ThreeDShape GetThreeDShape()
        {
            Random random = new Random();

            int whichShape = random.Next(1, 4);

            if (whichShape == 1)
            {

                Cube cube = new Cube(random.Next(1, 10));

                return cube;
            }

            if (whichShape == 2)
            {

                Sphere sphere = new Sphere(random.Next(1, 10));

                return sphere;
            }



            Tetrahedron tetrahedron = new Tetrahedron(random.Next(1, 10));

            return tetrahedron;




        }
    };
}
