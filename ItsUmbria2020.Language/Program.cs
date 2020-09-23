using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ItsUmbria2020.Language
{
    class Program
    {
        static List<string> List = new List<string>();
        static List<int> ListOfInt = new List<int>();
        //write I
        //check true
        //write I
        //check true
        //write I
        //check true
        //write I
        //check true
        //write I
        //check true
        //write I
        //check true
        //memory x = 2 (1)
        //if x         (10)
        //Construction Something
        //Get Y
        //Execution WriteLine
        //Execution Main
        static void Main(string[] args) //Execution Main
        {
            DateTime startTime = DateTime.UtcNow;
            StringBuilder stringBuilder = new StringBuilder();
            string a = "A";
            stringBuilder.Append(a);
            string b = "B";
            for (int i = 0; i < 1000000; i++)
            {
                //a += b;
                stringBuilder.Append(b);
            }
            //Console.WriteLine(stringBuilder);
            Console.WriteLine(DateTime.UtcNow.Subtract(startTime).TotalMilliseconds);
            Console.WriteLine(DateTime.UtcNow.Subtract(startTime).TotalSeconds);
            //Console.WriteLine(new Something(2).Y); //Execution WriteLine //Get Y //Constrution Something
            //int x = 2;
            //if (x < 2)
            //{

            //}
            //else if (x > 5)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Hello");
            //}
            ////stack overflow here
            ////while (true)
            ////    Console.Write("I");
            //for (int i = 0; i < 10; i++)
            //    List.Add((i + 167).ToString());
            //for (int i = 0; i < 10; i++)
            //    ListOfInt.Add(i + 167);
            //bool check = true;
            //while (check)
            //{
            //    check = !check;
            //}

            //Console.WriteLine("----------------------------------");
            //for (int i = 0; i < List.Count; i++)
            //    Console.WriteLine(List[i]);
            //Console.WriteLine("----------------------------------");
            //foreach (int value in ListOfInt)
            //    Console.WriteLine(value);
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
