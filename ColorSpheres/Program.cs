using System;
using System.Dynamic;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color(255, 0, 0);
            Color green = new Color(0, 255, 0);
            Color blue = new Color(0, 0, 255);

            Sphere sphere1 = new Sphere(red, 10);
            Sphere sphere2 = new Sphere(green, 15);
            Sphere sphere3 = new Sphere(blue, 20);

            sphere1.Throw();
            sphere2.Throw();
            sphere3.Throw();

            sphere1.Pop();

            Console.WriteLine("Sphere 1:");
            Console.WriteLine($"Radius: {sphere1.GetTimesThrown()}");
            Console.WriteLine($"Color: R={sphere1.GetColor().Red}, G={sphere1.GetColor().Green}, B={sphere1.GetColor().Blue}, A={sphere1.GetColor().Alpha}");

            Console.WriteLine("Sphere 2:");
            Console.WriteLine($"Radius: {sphere2.GetTimesThrown()}");
            Console.WriteLine($"Color: R={sphere2.GetColor().Red}, G={sphere2.GetColor().Green}, B={sphere2.GetColor().Blue}, A={sphere2.GetColor().Alpha}");

            Console.WriteLine("Sphere 3:");
            Console.WriteLine($"Radius: {sphere3.GetTimesThrown()}");
            Console.WriteLine($"Color: R={sphere3.GetColor().Red}, G={sphere3.GetColor().Green}, B={sphere3.GetColor().Blue}, A={sphere3.GetColor().Alpha}");
        }
    }
}