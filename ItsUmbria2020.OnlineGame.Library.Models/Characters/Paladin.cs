
using ItsUmbria2020.OnlineGame.Library.Models.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class Paladin : Healer
    {
        public Paladin() : base()
        {
        }
        public Paladin(string name) : base(name)
        {
        }

        protected override int BaseHealth => 125;
        protected override int BaseMana => 80;
    }
}
