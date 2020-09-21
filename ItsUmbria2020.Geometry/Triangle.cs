using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.Geometry
{
    class Triangle : SidedGeometry, IAreable
    {
        public double Height { get; set; }
        public Triangle(double side, double height)
        {
            this.Side = side;
            this.Height = height;
        }
        public double GetArea()
        {
            return Side * Height / 2;
        }
    }
}
