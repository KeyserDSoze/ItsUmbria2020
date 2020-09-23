using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.Garbaging
{
    interface IJunkFactory
    {
        Junk GetJunk(string junkType);
    }
    class JunkFactory : IJunkFactory
    {
        public Junk GetJunk(string junkType)
        {
            switch (junkType)
            {
                case "1":
                    return new Plastic();
                default:
                case "2":
                    return new Paper();
                case "3":
                    return new Glass();
            }
        }
    }
    abstract class Junk
    {
        public string Name => this.GetType().Name;
    }
    class Glass : Junk
    {

    }
    class Plastic : Junk
    {

    }
    class Paper : Junk
    {

    }
}
