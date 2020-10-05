using ItsUmbria2020.OnlineGame.Library.Base.Enumerator;
using ItsUmbria2020.OnlineGame.Library.Base.Interfaces;

using System;

namespace ItsUmbria2020.OnlineGame.Library.Base.Abstractions
{

    public abstract class Character : GameObject, IAttacker, IDamageable
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

        public abstract int BaseDamage { get; }
        public abstract int BaseDefense { get; }
        protected abstract int BaseHealth { get; }
        public int MaxHealth => BaseHealth * LevelWheigth();
        protected abstract int BaseMana { get; }
        public int MaxMana => BaseMana * LevelWheigth();
        public int HealthPoints { get; set; } = 100;
        public int ManaPoints { get; set; }
        public int Level { get; } = 1;
        public int ExpLevelUp { get; set; }
        public CharacterType Type { get; set; }

        private int LevelWheigth() => 1 + (int)((Level - 1) * 0.2);
        public virtual void PrintInfo() => Console.WriteLine($"{Name} --> Health {HealthPoints}, Mana {ManaPoints}");

        public void Attack(Character target)
        {
            Console.WriteLine($"{Name} attacking {target.Name}");
            target.GetDamage(BaseDamage);
        }
        public int GetDamage(int amount)
        {
            int wheightedDamage = amount - BaseDefense;
            if (wheightedDamage < 0)
            {
                wheightedDamage = 0;
            }
            HealthPoints -= wheightedDamage;

            if (HealthPoints < 0)
            {
                HealthPoints = 0;
            }
            Console.WriteLine($"{Name} gets {amount} damages. HP = {HealthPoints}");
            return amount;
        }
    }
}
