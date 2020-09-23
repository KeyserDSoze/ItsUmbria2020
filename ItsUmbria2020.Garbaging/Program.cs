using System;
using System.Collections.Generic;

namespace ItsUmbria2020.Garbaging
{
    class Program
    {
        static void Main(string[] args)
        {
            IJunkFactory junkFactory = new JunkFactory();
            do
            {
                Console.WriteLine("Che spazzatura vuoi buttare? 1) plastica 2) carta 3) vetro");
                string junkType = Console.ReadLine();
                Junk junk = junkFactory.GetJunk(junkType);
                Console.WriteLine("Con quale camion? 1) green, 2) normale, 3) pulitore");
                string camionType = Console.ReadLine();
                Sanitation.Instance(camionType).Manage(junk);
                Console.WriteLine("Vuoi buttare altro? S si, N no");
            } while (Console.ReadLine().ToLower() == "s");
        }
    }
}