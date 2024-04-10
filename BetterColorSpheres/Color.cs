using System;

namespace BetterColorSpheres
{
    class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        public Color()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
            Alpha = 255;
        }
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue) : this(red, green, blue, 255)
        {
        }

        public byte GetGrey()
        {
            return (byte)((Red + Green + Blue) / 3);
        }
    }

}