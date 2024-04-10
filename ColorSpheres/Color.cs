using System;
using System.Dynamic;

namespace ColorSpheres
{
    class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public byte Red
        {
            get { return red; }
            set { red = value; }
        }

        public byte Green
        {
            get { return green; }
            set { green = value; }
        }

        public byte Blue
        {
            get { return blue; }
            set { blue = value; }
        }

        public byte Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        public Color(byte r, byte g, byte b, byte a)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
        }

        public Color(byte r, byte g, byte b) : this(r, g, b, 255)
        {
        }

    }
}
