namespace ITSGame2020.OnlineGame.Library.Models
{
    public class Rogue : Character
    {
        public Rogue() : base()
        {
        }
        public Rogue(string name) : base(name)
        {
        }

        public override int MaxHealth => 110;
        public override int MaxMana => 50;
    }
}
