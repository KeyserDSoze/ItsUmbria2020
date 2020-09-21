using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.Geometry
{
    class ConsoleAppGeometryFactory : GeometryFactory
    {
        public override IAreable GetAreable()
        {
            Console.WriteLine("Quale figura vuoi utilizzare? 1) Triangle Y 2) Circle Red 3) Square D 4) Hexagon");
            int.TryParse(Console.ReadLine(), out int figure);
            switch (figure)
            {
                case 1:
                    Console.WriteLine("Inserisci il valore di lato e altezza");
                    return new Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                default:
                case 2:
                    Console.WriteLine("Inserisci il valore del raggio");
                    return new Circle(double.Parse(Console.ReadLine()));
            }
        }
    }
}
