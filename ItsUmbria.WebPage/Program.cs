using System;
using System.Threading;
using System.Threading.Tasks;

namespace ItsUmbria.WebPage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la frase che andrà nel div");
            string input = Console.ReadLine();
            Parallel.For(0, 100, i =>
                {
                    Console.BackgroundColor = Styling.Instance.BackgroundColor;
                    Console.ForegroundColor = Styling.Instance.ConsoleColor;
                    Console.WriteLine(string.Format(Styling.Instance.Html, input, i.ToString()));
                }
            );
            Console.WriteLine(Styling.Counter);
        }
    }
    class Styling
    {
        public ConsoleColor ConsoleColor { get; }
        public ConsoleColor BackgroundColor { get; }
        public string Html { get; }
        private static Styling styling;
        private readonly static object TrafficLight = new object();
        public static int Counter { get; private set; }
        public static Styling Instance
        {
            get
            {
                if (styling == null)
                {
                    lock (TrafficLight)
                    {
                        if (styling == null)
                        {
                            Thread.Sleep(1000);
                            Counter++;
                            styling = new Styling(ConsoleColor.Black, ConsoleColor.White, "<div>{0}</div><div>{1}<div><div>{0}<div>");
                        }
                    }
                }
                return styling;
            }
        }
        private Styling() { }
        private Styling(ConsoleColor consoleColor, ConsoleColor backgroundColor, string html)
        {
            this.ConsoleColor = consoleColor;
            this.BackgroundColor = backgroundColor;
            this.Html = html;
        }
    }
}