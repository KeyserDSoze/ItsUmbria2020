using ItsUmbria2020.OnlineGame.Library.Models.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class BattleMage : Wizard, IMagicFighter
    {
        public void Stun(Character target) => Actions.Stun.Do(this, target);
    }
}
