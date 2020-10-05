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

        protected override int BaseHealth => 130;
        protected override int BaseMana => 20;
    }
}
