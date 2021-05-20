using SimbrellaShapeTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbrellaShapeTask.Models
{
   public abstract class TwoDShape : IShape
    {
        public int A { get; set; }
        public  TwoDShape()
        {

        }       

       abstract public double GetArea();
       
    }
}
