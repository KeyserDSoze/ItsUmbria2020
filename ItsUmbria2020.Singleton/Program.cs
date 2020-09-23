using System;

namespace ItsUmbria2020.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.BackgroundColor = Styling.Instance().BackgroundColor;
                Console.ForegroundColor = Styling.Instance().ConsoleColor;
                
                Console.WriteLine("Hello World!");
            }
        }
    }
    class Styling
    {
        public ConsoleColor ConsoleColor { get; }
        public ConsoleColor BackgroundColor { get; }
        private static Styling styling;
        public static Styling Instance()
        {
            if (styling == null)
                styling = new Styling(ConsoleColor.Red, ConsoleColor.Blue);
            return styling;
        }
        private Styling() { }
        private Styling(ConsoleColor consoleColor, ConsoleColor backgroundColor)
        {
            this.ConsoleColor = consoleColor;
            this.BackgroundColor = backgroundColor;
        }
    }
}
