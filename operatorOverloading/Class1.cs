using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloading
{
    class Class1
    {
    }

    public class Rectangle
    {
        private int Height;
        private int Width;

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }
        public static bool operator >(Rectangle a, Rectangle b)
        {
            return a.Height > b.Height;
        }
        public static bool operator <(Rectangle a, Rectangle b)
        {
            return a.Height < b.Height;
        }
    }
}
