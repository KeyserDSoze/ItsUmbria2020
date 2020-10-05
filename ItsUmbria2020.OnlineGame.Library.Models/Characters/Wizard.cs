
using System;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class Wizard : Character
    {
        public Wizard() : base()
        {
        }
        public Wizard(string name) : base(name)
        {
            HealthPoints = MaxHealth;
            ManaPoints = MaxMana;
        }
        protected override int BaseHealthV2 => 100;
        protected override int BaseMana => 150;

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
