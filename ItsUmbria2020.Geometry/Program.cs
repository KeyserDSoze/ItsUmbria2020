using System;

namespace ItsUmbria2020.Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quale figura vuoi utilizzare? 1) Triangle 2) Circle 3) Square 4) Hexagon");
            int.TryParse(Console.ReadLine(), out int figure);
            IAreable areable = null;
            switch (figure)
            {
                case 1:
                    Console.WriteLine("Inserisci il valore di lato e altezza");
                    areable = new Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Inserisci il valore del raggio");
                    areable = new Circle(double.Parse(Console.ReadLine()));
                    break;
                case 4:
                    break;
            }
            Console.WriteLine(areable.GetArea());
        }
    }
}
