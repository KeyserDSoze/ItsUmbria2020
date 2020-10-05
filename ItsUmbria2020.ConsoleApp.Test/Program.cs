
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
                characterFactory.Create(CharacterClass.Warrior, "Player 1"),
                characterFactory.Create(CharacterClass.Wizard, "Player 2")
            );
            
            GameManager.Instance().PrintPlayers();
            var player1 = GameManager.Instance().Characters.FirstOrDefault();
            var player2 = GameManager.Instance().Characters.Skip(1).FirstOrDefault();
            if (player1 != null && player2 != null) 
            {
                //player1.Heal(player2, 10);
            }
        }
    }
}

