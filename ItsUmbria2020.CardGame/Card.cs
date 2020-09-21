using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.CardGame
{
    abstract class Card : object
    {
        public override string ToString()
        {
            return $"Name: {Name.ToLower()} - Description: {Description.ToUpper()} - Atk:{Attack} - Def:{Defense}";
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
    }
}
