using System;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class Warrior : Character
    {
        public Warrior() : base()
        {
        }
        public Warrior(string name) : base(name)
        {
        }
        public void Stun(Character target)
        {
            Console.WriteLine($"{this.Name} stunning {target.Name}");
        }
        public override int BaseDamage => 11;
        public override int BaseDefense => 3;
        protected override int BaseHealth => 130;
        protected override int BaseMana => 20;
    }
}
