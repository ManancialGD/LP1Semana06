classDiagram
    class Color {
        - byte Red
        - byte Green
        - byte Blue
        - byte Alpha
        + Color()
        + Color(byte red, byte green, byte blue, byte alpha)
        + Color(byte red, byte green, byte blue)
        + byte GetGrey()
    }
    class Sphere {
        - Color Color
        - double Radius
        - int TimesThrown
        + Sphere(Color color, double radius)
        + void Pop()
        + void Throw()
        + int GetTimesThrown()
    }
    class Program {
        static void Main(string[] args)
    }

    Color <-- Sphere
    Program --> Sphere
