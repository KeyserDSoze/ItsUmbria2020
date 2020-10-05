using ItsUmbria2020.OnlineGame.Library.Base.Abstractions;

using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Base.Interfaces
{
    public interface IHealer
    {
        int Heal(Character target, int amount);
    }
}
