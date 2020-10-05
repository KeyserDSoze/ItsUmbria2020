
using ItsUmbria2020.OnlineGame.Library.Models.Characters;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.ConsoleApp
{
    class Program
    {
        public static CharacterFactory characterFactory = new CharacterFactory();
        static void Main(string[] args)
        {
            GameManager.Instance().AddPlayers
            (
                //characterFactory.Create(CharacterClass.Warrior, "Player 1"),
                //characterFactory.Create(CharacterClass.Wizard, "Player 2")
            );
            
            GameManager.Instance().PrintPlayers();
            var player = GameManager.Instance().Characters.FirstOrDefault();
            if (player != null) 
            {
                // TODO: cura 
            }
        }
    }
}

