
using ItsUmbria2020.OnlineGame.Library.Models.Interfaces;

using System;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class Wizard : Character, IHealer
    {
        public Wizard() : base()
        {
        }
        public Wizard(string name) : base(name)
        {
            HealthPoints = MaxHealth;
            ManaPoints = MaxMana;
        }
        protected override int BaseHealth => 100;
        protected override int BaseMana => 150;

        public int Heal(Character target, int amount)
        {
            HealthPoints += amount;
            if (HealthPoints > MaxHealth)
                HealthPoints = MaxHealth;
            return amount;
        }

        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.PrintInfo();
            Console.ResetColor();
        }

        public void ThrowFireBall(Character target)
        {
            Console.WriteLine($"{Name} throws a fireball to {target.Name}");
        }
    }
}
