
using ItsUmbria2020.OnlineGame.Library.Models.Characters;

using System;
using System.Collections.Generic;
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
                characterFactory.Create(CharacterClass.Warrior, "MyName"),
                characterFactory.Create(CharacterClass.Wizard),
                characterFactory.Create(),
                characterFactory.Create(CharacterClass.Paladin, "Pippo")
            );
            GameManager.Instance().PrintPlayers();
        }
    }
}

