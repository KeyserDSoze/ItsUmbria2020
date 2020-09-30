
using ITSGame2020.OnlineGame.Library.Models;

using System;
using System.Collections.Generic;

namespace Test.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            Warrior warrior = new Warrior();
            Wizard wizard = new Wizard();
            Rogue rogue = new Rogue();
            characters.Add(warrior);
            characters.Add(wizard);
            characters.Add(rogue);

            foreach (Character character in characters)
            {
                Console.WriteLine($"{character.GetType().Name} Heath = {character.HealthPoints}");
                character.Heal(100);
                Console.WriteLine($"{character.GetType().Name} Heath = {character.HealthPoints}");

            }
        }
    }
}

