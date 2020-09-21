using System;

namespace ItsUmbria2020.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome");
            string name = Console.ReadLine();
            IdentityCard identityCard = new IdentityCard("Roma", name, "Hello", "M");
            DrivingLicense drivingLicense = new DrivingLicense()
            {
                Identity = new Identity
                {
                    Name = "Mario",
                    Surname = "Grigi"
                },
                Type = "B"
            };
            Console.WriteLine(identityCard.ToString());
            Console.WriteLine(drivingLicense.ToString());
        }
    }
}
