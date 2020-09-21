using System;

namespace ItsUmbria2020.CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la tipologia di carta: 1) Magic 2) Hearthstone");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il nome");
            string name = Console.ReadLine();
            Console.WriteLine("Inserisci la descrizione");
            string description = Console.ReadLine();
            Console.WriteLine("Inserisci l'attacco");
            int attack = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la difesa");
            int defense = int.Parse(Console.ReadLine());
            Card card = null;
            switch (value)
            {
                case 1:
                    Console.WriteLine("Inserisci il costo di mana rosso");
                    int redMana = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il costo di mana nero");
                    int blackMana = int.Parse(Console.ReadLine());
                    card = new Magic
                    {
                        Name = name,
                        Description = description,
                        Attack = attack,
                        Defense = defense,
                        Cost = new int[2] { redMana, blackMana }
                    };
                    break;
                default:
                case 2:
                    Console.WriteLine("Inserisci il costo");
                    int cost = int.Parse(Console.ReadLine());
                    card = new Hearthstone
                    {
                        Name = name,
                        Description = description,
                        Attack = attack,
                        Defense = defense,
                        Cost = cost
                    };
                    break;
            }
            Console.WriteLine($"La carta inserita è: {card}");
        }
    }
}
