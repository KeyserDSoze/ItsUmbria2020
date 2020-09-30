using System;

namespace ITSGame2020.OnlineGame.Library.Models
{

    public abstract class Character
    {
        public string Name { get; set; } = "Player";
        public Gender Gender { get; set; }

        public abstract int MaxHealth { get; }
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

    public enum CharacterType
    {

        Human,
        Elf,
        Orc
    }

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }

    public class Wizard : Character
    {
        public override int MaxHealth => 100;
    }

    public class Rogue : Character
    {
        public override int MaxHealth => 110;
    }

    public class Warrior : Character
    {
        public override int MaxHealth => 130;
    }
}
