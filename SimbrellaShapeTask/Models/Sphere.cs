using System;
using System.Collections.Generic;
using System.Text;

namespace SimbrellaShapeTask.Models
{
    class Sphere : ThreeDShape
    {
        public int A { get; set; }

        public double AreaOfSphere { get; set; }

        public double VolumeOfSphere { get; set; }
        public Sphere(int a) 
        {
            A = a;
        }     

        public override double GetArea()
        {
            AreaOfSphere = 12 * A * A;
            return AreaOfSphere;
        }

        public override double GetVolume()
        {
            VolumeOfSphere = (4 * 3 * A * A * A) / 3;
            return VolumeOfSphere;
        }

        public override string ToString()
        {
            return $" {nameof(Rectangle)}(3D({A},==> Area = {GetArea()}, Volume = {GetVolume()}";
        }
    }
}
