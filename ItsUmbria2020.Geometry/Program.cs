using System;

namespace ItsUmbria2020.Geometry
{
    class Program
    {
        static GeometryFactory GeometryFactory = new ConsoleAppGeometryFactory();
        static void Main(string[] args)
        {
            IAreable areable = GeometryFactory.GetAreable();
            Console.WriteLine($"AAAgfdgfdgfdg {areable.GetArea()}");
        }
    }
}
