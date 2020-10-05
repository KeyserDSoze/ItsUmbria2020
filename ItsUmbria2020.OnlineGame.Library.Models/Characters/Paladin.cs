
using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class Paladin : Character
    {
        public Paladin()
        {
        }
        public Paladin(string name) : base(name)
        {
        }

        public override int BaseDamage => 10;
        public override int BaseDefense => 2;

        protected override int BaseHealth => 125;
        protected override int BaseMana => 80;
    }
}
