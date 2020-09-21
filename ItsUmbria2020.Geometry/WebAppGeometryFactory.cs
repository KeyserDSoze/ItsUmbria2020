using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.Geometry
{
    class WebAppGeometryFactory : GeometryFactory
    {
        public override IAreable GetAreable()
        {
            Console.WriteLine("<div>Quale figura vuoi utilizzare? 1) Triangle Y 2) Circle Red 3) Square D 4) Hexagon</div>");
            int.TryParse(Console.ReadLine(), out int figure);
            switch (figure)
            {
                case 1:
                    Console.WriteLine("<div>Inserisci il valore di lato e altezza</div>");
                    return new Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                default:
                case 2:
                    Console.WriteLine("<div>Inserisci il valore di raggio</div>");
                    return new Circle(double.Parse(Console.ReadLine()));
            }
        }
    }
}
