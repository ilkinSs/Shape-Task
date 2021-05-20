using System;
using System.Collections.Generic;
using System.Text;

namespace SimbrellaShapeTask.Models
{
    public class Circle : TwoDShape
    {
        public int A { get; set; }

        public double AreaOfCircle { get; set; }
        public Circle(int a)
        {
            A = a;
        }
   
        public override double GetArea()
        {
            AreaOfCircle = 6 * A * A;
            return AreaOfCircle;
        }

        public override string ToString()
        {
            return $" {nameof(Circle)}(2D({A}==> Area = {GetArea()}";
        }

    }
}
