
using ItsUmbria2020.OnlineGame.Library.Base.Abstractions;
using ItsUmbria2020.OnlineGame.Library.Base.Interfaces;

using System;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class Wizard : Healer, IMagician
    {
        public Wizard() : base()
        {
        }
        public Wizard(string name) : base(name)
        {
            HealthPoints = MaxHealth;
            ManaPoints = MaxMana;
        }
        public override int BaseDamage => 5;
        public override int BaseDefense => 0;
        protected override int BaseHealth => 100;
        protected override int BaseMana => 150;
        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.PrintInfo();
            Console.ResetColor();
        }
        public void ThrowSpell(Character target)
        {
            Console.WriteLine($"{Name} throws a spell to {target.Name}");
        }
    }
}
