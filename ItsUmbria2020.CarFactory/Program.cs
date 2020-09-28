using System;
using System.Collections.Generic;

namespace ItsUmbria2020.CarFactory
{
    class Program
    {
        static CarFactory CarFactory = new CarFactory();
        static void Main(string[] args)
        {
            //Console.WriteLine("Qui mettete l'inserimento dei campi che servono");
            //Console.WriteLine("e poi a video deve mostrare l'auto inserita o le auto inserite.");
            //Console.WriteLine("solo per il SUV vogliamo avere a video anche la cilindrata");
            //Console.WriteLine("solo per la COUPE vogliamo avere a video anche il colore");
            //Console.WriteLine("esempio: Abbiamo immatricolato la macchina SUV FF049CA cc2000 di Mario Rossi");
            //Console.WriteLine("esempio: Abbiamo immatricolato la macchina COUPE rossa FF050CA di Mauro Verdi");
            //Console.WriteLine("esempio: Abbiamo immatricolato la macchina SW FF050CA di Carlo Carli");
            string name = RequestValue("nome del proprietario");
            string surname = RequestValue("cognome del proprietario");
            string plate = RequestValue("targa");
            string type = RequestValue("tipologia della macchina: 1) Suv, 2) Coupe");
            Car car = CarFactory.Create(new Owner { Name = name, Surname = surname }, new Data { Plate = plate }, type);
            if (car is IColorable)
            {
                ((IColorable)car).Color = RequestValue("il colore della macchina");
            }
            if (car is ICilindrable)
            {
                ((ICilindrable)car).Cilinder = int.Parse(RequestValue("la cilindrata della macchina"));
            }
            Console.WriteLine(car);
        }
        private static string RequestValue(string what)
        {
            Console.WriteLine($"Inserisci {what}");
            return Console.ReadLine();
        }
    }
}
