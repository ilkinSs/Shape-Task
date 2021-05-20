using System;
using System.Collections.Generic;
using System.Text;

namespace SimbrellaShapeTask.Models
{
  public  class Tetrahedron : ThreeDShape
    {
        public int A { get; set; }

        public double AreaOfTetrahedron { get; set; }

        public double VolumeOfTetrahedron { get; set; }
        public Tetrahedron(int a) 
        {
            A = a;
        }

   

        public override double GetArea()
        {
            AreaOfTetrahedron = Math.Sqrt(3) * A * A;

            return AreaOfTetrahedron;
        }

        public override double GetVolume()
        {
            VolumeOfTetrahedron = (A * A * A) / (6 * (Math.Sqrt(2)));
            return VolumeOfTetrahedron;
        }

        public override string ToString()
        {
            return $" {nameof(Tetrahedron)}(3D({A},==> Area = {GetArea()}, Volume = {GetVolume()}";
        }
    }
}
