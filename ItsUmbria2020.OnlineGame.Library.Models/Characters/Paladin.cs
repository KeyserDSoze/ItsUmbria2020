
using ItsUmbria2020.OnlineGame.Library.Models.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class Paladin : Character, IHealer
    {
        public Paladin()
        {
        }
        public Paladin(string name) : base(name)
        {
        }
        public int Heal(Character target, int amount)
        {
            HealthPoints += amount;
            if (HealthPoints > MaxHealth)
                HealthPoints = MaxHealth;
            return amount;
        }
        protected override int BaseHealth => 125;
        protected override int BaseMana => 80;
    }
}
