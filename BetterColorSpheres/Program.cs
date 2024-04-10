using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color { Red = 255, Green = 0, Blue = 0 };
            Color green = new Color { Red = 0, Green = 255, Blue = 0 };
            Color blue = new Color { Red = 0, Green = 0, Blue = 255 };

            Sphere sphere1 = new Sphere(red, 10);
            Sphere sphere2 = new Sphere(green, 15);
            Sphere sphere3 = new Sphere(blue, 20);

            sphere1.Throw();
            sphere2.Throw();
            sphere3.Throw();

            sphere1.Pop();

            Console.WriteLine("Sphere 1:");
            Console.WriteLine($"Radius: {sphere1.GetTimesThrown()}");
            Console.WriteLine($"Color: R={sphere1.Color.Red}, G={sphere1.Color.Green}, B={sphere1.Color.Blue}, A={sphere1.Color.Alpha}");

            Console.WriteLine("Sphere 2:");
            Console.WriteLine($"Radius: {sphere2.GetTimesThrown()}");
            Console.WriteLine($"Color: R={sphere2.Color.Red}, G={sphere2.Color.Green}, B={sphere2.Color.Blue}, A={sphere2.Color.Alpha}");

            Console.WriteLine("Sphere 3:");
            Console.WriteLine($"Radius: {sphere3.GetTimesThrown()}");
            Console.WriteLine($"Color: R={sphere3.Color.Red}, G={sphere3.Color.Green}, B={sphere3.Color.Blue}, A={sphere3.Color.Alpha}");
        }
    }
}
