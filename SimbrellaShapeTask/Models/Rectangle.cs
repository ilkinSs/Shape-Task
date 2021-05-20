using System;
using System.Collections.Generic;
using System.Text;

namespace SimbrellaShapeTask.Models
{
   public class Rectangle : TwoDShape
    {
        public int A { get; set; }

 


        public double AreaOfRectangle { get; set; }
        public Rectangle(int a) 
        {
            A = a;
          
          
        }

    

        public override double GetArea()
        {
            AreaOfRectangle = A * A;
            return AreaOfRectangle;
        }

        public override string ToString()
        {
            return $" {nameof(Rectangle)}(2D({A} ==> Area = {GetArea()}";
        }
    }
}
