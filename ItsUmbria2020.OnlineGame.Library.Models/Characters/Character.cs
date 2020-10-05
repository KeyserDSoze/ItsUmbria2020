
using System;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{

    public abstract class Character
    {
        private readonly string name = null;
        public Character()
        {
            HealthPoints = MaxHealth;
            ManaPoints = MaxMana;
        }
        public Character(string name) : this()
        {
            this.name = name;
        }

        protected virtual string DefaultName => GetType().Name;
        public virtual string Name
        {
            get
            {
                if (name != null)
                    return name;
                else
                    return DefaultName;
            }
        }
        public Gender Gender { get; set; }

        protected abstract int BaseHealthV2 { get; }
        public int MaxHealth => BaseHealthV2 * LevelWheigth();
        protected abstract int BaseMana { get; }
        public int MaxMana => BaseMana * LevelWheigth();
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

        private int LevelWheigth() => 1 + (int)((Level - 1) * 0.2);
        public virtual void PrintInfo() => Console.WriteLine($"{Name} --> Health {HealthPoints}, Mana {ManaPoints}");
    }
}
