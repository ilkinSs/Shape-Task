using System;
using System.Collections.Generic;
using System.Text;

namespace SimbrellaShapeTask.Models
{
   public class Cube : ThreeDShape
    {
        public int A { get; set; }

        public double AreaOfCube { get; set; }

        public double VolumeOfCube { get; set; }
        public Cube(int a)
        {
            A = a;
        }

        public override double GetArea()
        {
            AreaOfCube = 6 * A * A;
            return AreaOfCube;
        }

        public override double GetVolume()
        {
            VolumeOfCube = A * A * A;
            return VolumeOfCube;
        }

        public override string ToString()
        {
            return $" {nameof(Rectangle)}(3D({A},==> Area = {GetArea()}, Volume = {GetVolume()}";
        }
    }
}
