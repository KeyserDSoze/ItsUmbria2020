using ItsUmbria2020.OnlineGame.Library.Models.Characters;

using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Models.Actions
{
    static class Stun
    {
        public static void Do(Character executor, Character target)
        {
            Console.WriteLine($"{executor.Name} stunning {target.Name}");
            // Do some other things
        }
    }
}
