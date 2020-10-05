
using ItsUmbria2020.OnlineGame.Library.Base.Abstractions;
using ItsUmbria2020.OnlineGame.Library.Base.Enumerator;
using ItsUmbria2020.OnlineGame.Library.Base.Interfaces;
using ItsUmbria2020.OnlineGame.Library.Models.Characters;
using ItsUmbria2020.OnlineGame.Library.Orchestration;

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
            string lobbyId = CallServerAndCreateLobby("ITS");
            CallServerAndremoveLobby(lobbyId);
        }
        private static string CallServerAndCreateLobby(string lobbyName)
        {
            GameManager.Instance().CreateLobby(lobbyName);
            Lobby lobby = GameManager.Instance().GetLobbyInstance(Guid.NewGuid().ToString(), lobbyName);
            lobby.AddPlayers
            (
                characterFactory.Create(CharacterClass.BattleMage),
                characterFactory.Create(CharacterClass.Necromancer),
                characterFactory.Create(CharacterClass.Wizard),
                characterFactory.Create(CharacterClass.Paladin)
            );

            GameManager.Instance().PrintAllPlayers();
            Character target = GameManager.Instance().GetLobbyInstance(lobby.Id, lobby.Name).GetFirstPlayer();


            foreach (Character player in lobby.Characters)
            {
                Console.WriteLine($"Actions of {player.Name}");
                if (player is INecromancer necromancer)
                {
                    necromancer.Resurrect(target);
                }
                if (player is IAttacker attacker)
                {
                    attacker.Attack(target);
                }
                if (player is IMagician magician)
                {
                    magician.ThrowSpell(target);
                }
                if (player is IStunner stunner)
                {
                    stunner.Stun(target);
                }
                Console.WriteLine();
            }
            return lobby.Id;
        }
        private static void CallServerAndremoveLobby(string lobbyName) 
        {
            GameManager.Instance().RemoveLobby(lobbyName);
        }
    }
}

