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
    interface IJunkFactory
    {
        Junk GetJunk(string junkType);
    }
    class JunkFactory : IJunkFactory
    {
        public Junk GetJunk(string junkType)
        {
            switch (junkType)
            {
                case "1":
                    return new Plastic();
                default:
                case "2":
                    return new Paper();
                case "3":
                    return new Glass();
            }
        }
    }
    abstract class Junk
    {
        public string Name => this.GetType().Name;
    }
    class Glass : Junk
    {

    }
    class Plastic : Junk
    {

    }
    class Paper : Junk
    {

    }
    interface ICamion
    {
        void Manage(Junk junk);
    }
    class Sanitation
    {
        private static readonly Dictionary<string, ICamion> Camions = new Dictionary<string, ICamion>();
        private static readonly object Semaphore = new object();
        public static ICamion Instance(string key)
        {
            if (!Camions.ContainsKey(key))
            {
                lock (Semaphore)
                {
                    if (!Camions.ContainsKey(key))
                    {
                        if (key == "1")
                            Camions.Add(key, new GreenCamion());
                        else if (key == "2")
                            Camions.Add(key, new Camion());
                        else
                            Camions.Add(key, new CleanCamion());
                    }
                }
            }
            return Camions[key];
        }
    }
    class Camion : ICamion
    {
        public void Manage(Junk junk)
        {
            Console.WriteLine($"Burn {junk.Name}");
        }
    }
    class GreenCamion : ICamion
    {
        public void Manage(Junk junk)
        {
            Console.WriteLine($"Recycle {junk.Name}");
        }
    }
    class CleanCamion : ICamion
    {
        public void Manage(Junk junk)
        {
            Console.WriteLine($"Clean {junk.Name}");
        }
    }
}
