using System;

namespace ITSGame2020.OnlineGame.Library.Models
{

    public abstract class Character
    {
        private readonly string name = null;
        public Character()
        {
            this.HealthPoints = this.MaxHealth;
            this.ManaPoints = this.MaxMana;
        }
        public Character(string name) : this()
        {
            this.name = name;
        }

        protected virtual string DefaultName => this.GetType().Name;
        public virtual string Name 
        {
            get 
            {
                if (this.name != null)
                    return name;
                else
                    return DefaultName;
            }
        }
        public Gender Gender { get; set; }

        public abstract int MaxHealth { get; }
        public abstract int MaxMana { get; }
        public int HealthPoints { get; set; } = 100;
        public int ManaPoints { get; set; }
        public int Level { get; } = 1;
        public int ExpLevelUp { get; set; }

        public void Heal(int amount)
        {
            HealthPoints += amount;
            if (HealthPoints > MaxHealth)
                HealthPoints = MaxHealth;
        }
        public CharacterType Type { get; set; }
    }
}
