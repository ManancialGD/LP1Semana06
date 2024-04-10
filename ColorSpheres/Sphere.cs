using System;
using System.Dynamic;
using System.IO.Compression;

namespace ColorSpheres
{

    class Sphere
    {
        private Color color;
        private double radius;
        private int timesThrown;

        public Sphere(Color color, double radius)
        {
            this.color = color;
            this.radius = radius;
            this.timesThrown = 0;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                timesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return timesThrown;
        }

        public Color GetColor()
        {
            return color;
        }
    }
}