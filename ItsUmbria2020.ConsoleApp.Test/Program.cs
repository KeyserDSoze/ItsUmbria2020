
using ItsUmbria2020.OnlineGame.Library.Models.Characters;
using ItsUmbria2020.OnlineGame.Library.Models.Interfaces;

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
                characterFactory.Create(CharacterClass.BattleMage),
                characterFactory.Create(CharacterClass.Necromancer),
                characterFactory.Create(CharacterClass.Wizard),
                characterFactory.Create(CharacterClass.Paladin)
            );
            
            GameManager.Instance().PrintPlayers();
            Character player2 = GameManager.GetFirstPlayer();

            foreach (Character player in GameManager.Instance().Characters)
            {
                Console.WriteLine($"Actions of {player.Name}");
                if (player is INecromancer necromancer)
                {
                    necromancer.Resurrect(player2);
                }
                if (player is IAttacker attacker) 
                {
                    attacker.Attack(player2);
                }
                if (player is IMagician magician)
                {
                    magician.ThrowSpell(player2);
                }
                if (player is IStunner stunner)
                {
                    stunner.Stun(player2);
                }
                Console.WriteLine();
            }
        }
    }
}

