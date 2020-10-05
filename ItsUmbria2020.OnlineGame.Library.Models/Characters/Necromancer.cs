using ItsUmbria2020.OnlineGame.Library.Models.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class Necromancer : Wizard, INecromancer
    {
        public Necromancer() : base ()
        {
        }
        public Necromancer(string name) : base(name)
        {
        }
        public void Resurrect(Character character) 
        {
            Console.WriteLine($"Resurrecting {character.Name}");
        }
    }
}
