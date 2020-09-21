using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.Geometry
{
    class Circle : IAreable
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
