using System;
using System.Dynamic;
using System.IO.Compression;

namespace ColorSpheres
{

    class Sphere
    {
        byte[] colors;
        double radius;
        int timesThrown;

        public Sphere(byte[] colors, double radius)
        {
            this.colors = colors;
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

        // Getters & Setters
        public byte[] GetColors()
        {
            return this.colors;
        }

        public void SetColors(byte[] colors)
        {
            this.colors = colors;
        }

        public double GetRadius()
        {
            return this.radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public int GetTimesThrown()
        {
            return this.timesThrown;
        }

    }
}