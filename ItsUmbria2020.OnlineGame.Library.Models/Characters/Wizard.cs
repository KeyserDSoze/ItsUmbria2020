
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
        public override int BaseDamage => 5;
        public override int BaseDefense => 0;
        protected override int BaseHealth => 100;
        protected override int BaseMana => 150;

        public void ThrowFireBall(Character target)
        {
            Console.WriteLine($"{Name} throws a fireball to {target.Name}");
        }
    }
}
