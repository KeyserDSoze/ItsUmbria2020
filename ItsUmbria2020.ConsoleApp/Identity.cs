using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.ConsoleApp
{
    class Identity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return $"{Name.ToLower()} - {Surname}";
        }
    }
}
