
using ITSGame2020.OnlineGame.Library.Models;

using System;

namespace Test.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Wizard();
            PrintCharacter(new Wizard());
        }

        private static void PrintCharacter(Character character) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(character.Name);
            Console.ResetColor();
        }
    }
}
