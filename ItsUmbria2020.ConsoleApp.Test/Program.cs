
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
                characterFactory.Create(CharacterClass.Necromancer, "Player 1"),
                characterFactory.Create(CharacterClass.Wizard, "Player 2")
            );
            
            GameManager.Instance().PrintPlayers();
            Character player1 = GameManager.GetFirstPlayer();
            Character player2 = GameManager.GetFirstPlayer();
            if (player1 is Necromancer necromancer)
            {
                necromancer.ThrowSpell(player2);
                necromancer.ThrowSpell(player2);
                necromancer.Attack(player2);
                necromancer.Resurrect(player2);
            }
            
        }
    }
}

