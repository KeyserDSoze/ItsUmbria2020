using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ItsUmbria.MultiWebPage
{
    class Program
    {
        static string[] Test = new string[4] { "FirstPage", "SecondPage", "ThirdPage", "FourthPage" };
        private static readonly object Semaphore = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la frase che andrà nel div");
            string input = Console.ReadLine();
            //warm up instances
            Styling.Instance(Test[0]);
            Styling.Instance(Test[1]);
            Styling.Instance(Test[2]);
            Styling.Instance(Test[3]);

            Parallel.For(0, 100, i =>
            {
                lock (Semaphore)
                {
                    Console.BackgroundColor = Styling.Instance(Test[i % 4]).BackgroundColor;
                    Console.ForegroundColor = Styling.Instance(Test[i % 4]).ConsoleColor;
                    Console.WriteLine(string.Format(Styling.Instance(Test[i % 4]).Html, input, i.ToString()));
                }
            }
            );
            Console.WriteLine(Styling.Counter);
        }
    }
    static class StylingDatabase
    {
        public static Styling FirstPage { get; } = new Styling(ConsoleColor.Black, ConsoleColor.White, "<div>{0}</div><div>{1}<div><div>{0}<div>");
        public static Styling SecondPage { get; } = new Styling(ConsoleColor.Blue, ConsoleColor.Red, "<h1>{0}</h1><div>{1}<div>");
        public static Styling ThirdPage { get; } = new Styling(ConsoleColor.Cyan, ConsoleColor.Green, "<h2>{0}</h2><div>{0}<div>");
        public static Styling FourthPage { get; } = new Styling(ConsoleColor.Yellow, ConsoleColor.DarkMagenta, "<h2>{0}</h2>");
        public static Styling GetStyling(string key)
        {
            Thread.Sleep(2000);
            if (key == "FirstPage")
                return StylingDatabase.FirstPage;
            else if (key == "SecondPage")
                return StylingDatabase.SecondPage;
            else if (key == "ThirdPage")
                return StylingDatabase.ThirdPage;
            else if (key == "FourthPage")
                return StylingDatabase.FourthPage;
            return null;
        }
    }
    class Styling
    {
        public ConsoleColor ConsoleColor { get; }
        public ConsoleColor BackgroundColor { get; }
        public string Html { get; }
        private static Dictionary<string, Styling> styling = new Dictionary<string, Styling>();
        private readonly static object TrafficLight = new object();
        public static int Counter { get; private set; }
        public static Styling Instance(string key)
        {
            if (!styling.ContainsKey(key))
            {
                lock (TrafficLight)
                {
                    if (!styling.ContainsKey(key))
                    {
                        Counter++;
                        styling.Add(key, StylingDatabase.GetStyling(key));
                    }
                }
            }
            return styling[key];
        }
        public Styling(ConsoleColor consoleColor, ConsoleColor backgroundColor, string html)
        {
            this.ConsoleColor = consoleColor;
            this.BackgroundColor = backgroundColor;
            this.Html = html;
        }
    }
}