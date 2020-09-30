using System;

namespace ITSGame2020.OnlineGame.Library.Models
{
    public class Wizard : Character
    {
        public Wizard() : base()
        {
        }
        public Wizard(string name) : base(name)
        {
            this.HealthPoints = MaxHealth;
            this.ManaPoints = MaxMana;
        }
        public override int MaxHealth => 100;
        public override int MaxMana => 150;

        public void ThrowFireBall(Character target) 
        {
            Console.WriteLine($"{this.Name} throws a fireball to {target.Name}");
        }
    }
}
