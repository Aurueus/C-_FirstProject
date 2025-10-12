using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nine
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public Rectangle(){}

        public double GetArea()
        {
            return Width * Height;
        }
    }
}