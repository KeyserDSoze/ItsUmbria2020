
using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Base.Interfaces
{
    public interface IDamageable
    {
        int GetDamage(int amount);
        int HealthPoints { get; }
    }
}
