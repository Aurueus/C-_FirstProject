using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nine
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public Circle(){}

        public double GetArea()
        {
            return Radius * Math.PI * Radius;
        }
    }
}