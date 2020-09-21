using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.Geometry
{
    class Square : SidedGeometry, IAreable, IPerimeterable
    {
        public double GetArea()
        {
            return Side * Side;
        }

        public double GetPerimeter()
        {
            return Side * 4;
        }
    }
}
