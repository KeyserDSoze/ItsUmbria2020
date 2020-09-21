using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.CardGame
{
    class Hearthstone : Card
    {
        public int Cost { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()} - Cost: {Cost}";
        }
    }
}
