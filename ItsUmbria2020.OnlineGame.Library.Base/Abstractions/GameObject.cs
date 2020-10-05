using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Base.Abstractions
{
    public class GameObject
    {
        public string Id { get; } = Guid.NewGuid().ToString();
    }
}
