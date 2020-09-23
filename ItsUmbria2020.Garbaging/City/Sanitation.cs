using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.Garbaging
{
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
