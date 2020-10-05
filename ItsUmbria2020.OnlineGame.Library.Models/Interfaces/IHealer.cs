﻿using ItsUmbria2020.OnlineGame.Library.Models.Characters;

using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Models.Interfaces
{
    public interface IHealer
    {
        int Heal(Character target, int amount);
    }
}