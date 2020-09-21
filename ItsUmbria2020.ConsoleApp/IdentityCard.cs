using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.ConsoleApp
{
    class IdentityCard
    {
        public string Municipality { get; set; }
        public Identity Identity { get; set; }
        public string Sex { get; set; }
        public IdentityCard(string municipality, string name, string surname, string sex)
        {
            this.Municipality = municipality;
            this.Identity = new Identity()
            {
                Name = name,
                Surname = surname
            };
            this.Sex = sex;
        }
        public override string ToString()
        {
            return $"{Municipality} - {Identity} - {Sex}";
        }
    }
}
