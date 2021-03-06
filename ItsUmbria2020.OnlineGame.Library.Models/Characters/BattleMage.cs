﻿using ItsUmbria2020.OnlineGame.Library.Base.Abstractions;
using ItsUmbria2020.OnlineGame.Library.Base.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class BattleMage : Wizard, IMagicFighter
    {
        public BattleMage(string name) : base(name)
        {
        }

        public void Stun(Character target) => Actions.Stun.Do(this, target);
    }
}
