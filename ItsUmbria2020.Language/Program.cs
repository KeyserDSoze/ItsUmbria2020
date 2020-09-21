using System;
using System.Collections.Generic;

namespace ItsUmbria2020.Language
{
    class Program
    {
        static List<string> List = new List<string>();
        static List<int> ListOfInt = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine(new Something(2).Y);
            int x = 2;
            if (x < 2)
            {

            }
            else if (x > 5)
            {

            }
            else
            {
                Console.WriteLine("Hello");
            }
            for (int i = 0; i < 10; i++)
                List.Add((i + 167).ToString());
            for (int i = 0; i < 10; i++)
                ListOfInt.Add(i + 167);
            bool check = true;
            while (check)
            {
                check = !check;
            }

            Console.WriteLine("----------------------------------");
            for (int i = 0; i < List.Count; i++)
                Console.WriteLine(List[i]);
            Console.WriteLine("----------------------------------");
            foreach (int value in ListOfInt)
                Console.WriteLine(value);
        }
    }
    class Something
    {
        private int X;
        public void SetX(int x)
        {
            this.X = x;
        }
        public int GetX()
        {
            return this.X;
        }
        public int Y { get; }
        public Something(int y)
        {
            this.Y = y;
        }
    }
}
