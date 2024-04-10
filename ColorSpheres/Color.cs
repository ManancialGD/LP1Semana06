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

        // Constructor that accepts all the necessary parameters to initialize the state of a color.
        public Color(byte r, byte g, byte b, byte a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;
        }

        // Constructor that accepts red, green, and blue, setting alpha to 255 (opaque).
        public Color(byte r, byte g, byte b) : this(r, g, b, 255)
        {
            red = r;
            green = g;
            blue = b;

        }

        // getters & setters
        public byte GetGrey()
        {
            return (byte)((red + blue + green) / 3);
        }

        public byte GetRed()
        {
            return this.red;
        }

        public void SetRed(byte red)
        {
            this.red = red;
        }

        public byte GetGreen()
        {
            return this.green;
        }

        public void SetGreen(byte green)
        {
            this.green = green;
        }

        public byte GetBlue()
        {
            return this.blue;
        }

        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }

        public byte GetAlpha()
        {
            return this.alpha;
        }

        public void GetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }
    }
}
