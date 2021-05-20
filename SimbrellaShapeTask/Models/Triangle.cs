using System;
using System.Collections.Generic;
using System.Text;

namespace SimbrellaShapeTask.Models
{
  public  class Triangle : TwoDShape
    {
        public int A { get; set; }

        public int Perimeter { get; set; }
        public double AreaOfTriangle { get; set; }
        public Triangle(int a) 
        {
            A = a;         
        }  
        public override double GetArea()
        {
            AreaOfTriangle = (Math.Sqrt(3) * Math.Pow(A, 2))/4;
            //Perimeter = 3 * (A) / 2;
            //AreaOfTriangle = Math.Sqrt(Perimeter * (Perimeter - A) * (Perimeter - A) * (Perimeter - A));
            return AreaOfTriangle;
        }

        public override string ToString()
        {
            return $" {nameof(Triangle)}(2D({A} ==> Area = {GetArea()}";
        }
    }
}
