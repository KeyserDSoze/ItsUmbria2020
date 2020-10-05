using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Base.Abstractions
{
    public abstract class Healer : Character
    {
        public Healer() : base()
        {
        }
        protected Healer(string name) : base(name)
        {
        }

        public int Heal(Character target, int amount)
        {
            HealthPoints += amount;
            if (HealthPoints > MaxHealth)
                HealthPoints = MaxHealth;
            return amount;
        }
    }
}
