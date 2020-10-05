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

        protected override int BaseHealthV2 => 110;
        protected override int BaseMana => 50;
    }
}
