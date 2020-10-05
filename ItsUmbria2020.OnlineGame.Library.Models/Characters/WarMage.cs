using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class WarMage : Wizard
    {
        public override int BaseDamage => 9;
        public override int BaseDefense => 8;
        protected override int BaseHealth => 120;
        protected override int BaseMana => 110;
    }
}
