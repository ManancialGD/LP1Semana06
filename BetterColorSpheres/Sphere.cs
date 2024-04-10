using System;

namespace BetterColorSpheres
{
     class Sphere
    {
        public Color Color { get; set; }
        public double Radius { get; set; }
        public int TimesThrown { get; private set; }

        public Sphere(Color color, double radius)
        {
            Color = color;
            Radius = radius;
            TimesThrown = 0;
        }
        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
            {
                TimesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return TimesThrown;
        }
    }
}