using SimbrellaShapeTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbrellaShapeTask.Models
{
   public abstract  class ThreeDShape : IShape
    {
        public int A { get; set; }
    
        public ThreeDShape()
        {

        }   
        abstract public double GetArea();

        abstract public double GetVolume();

    }
}
