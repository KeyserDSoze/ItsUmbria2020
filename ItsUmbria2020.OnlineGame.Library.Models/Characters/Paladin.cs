
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

        protected override int BaseHealth => 120;
        protected override int BaseMana => 80;
    }
}
