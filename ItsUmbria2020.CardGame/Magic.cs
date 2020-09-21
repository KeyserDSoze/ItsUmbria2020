using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.CardGame
{
    class Magic : Card
    {
        public int[] Cost { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()} - Cost: Red-> {Cost[0]}, Black-> {Cost[1]}";
        }
    }
}
