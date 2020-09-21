using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.ConsoleApp
{
    class DrivingLicense
    {
        public Identity Identity { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return $"{Identity} - {Type}";
        }
    }
}
