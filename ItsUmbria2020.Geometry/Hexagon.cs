using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.Geometry
{
    class Hexagon : SidedGeometry, IAreable, IPerimeterable
    {
        public double GetArea() => Side * Side / 6;

        public double GetPerimeter()
        {
            return Side * Side * 3 * Math.Sqrt(3) / 2;
        }
    }
}
