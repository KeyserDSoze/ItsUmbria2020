namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class Rogue : Character
    {
        public Rogue() : base()
        {
        }
        public Rogue(string name) : base(name)
        {
        }

        protected override int BaseHealth => 110;
        protected override int BaseMana => 50;
    }
}
