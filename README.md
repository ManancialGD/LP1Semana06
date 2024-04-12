classDiagram
    Color <|-- Sphere : Contains
    Program --> Sphere : Uses
    Color : +byte Red
    Color : +byte Green
    Color : +byte Blue
    Color : +byte Alpha
    Color : +Color()
    Color : +Color(byte red, byte green, byte blue, byte alpha)
    Color : +Color(byte red, byte green, byte blue)
    Color : +byte GetGrey()
    Sphere : -Color Color
    Sphere : -double Radius
    Sphere : -int TimesThrown
    Sphere : +Sphere(Color color, double radius)
    Sphere : +void Pop()
    Sphere : +void Throw()
    Sphere : +int GetTimesThrown()
    Program : static void Main(string[] args)
