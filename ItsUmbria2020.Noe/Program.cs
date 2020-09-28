using System;

namespace ItsUmbria2020.Noe
{
    class Program
    {
        static AnimalFactory AnimalFactory = new AnimalFactory();
        static void Main(string[] args)
        {
            Animal animal = AnimalFactory.Create(AnimalType.Herbivore, "tartaruga");
            Console.WriteLine(animal);
            //Console.WriteLine("es: Ciao sono Noè ed ho dato da mangiare all'animale erbivoro tartaruga dell'erba.");
            //Console.WriteLine("es: Ciao sono Noè ed ho dato da mangiare all'animale carnivoro cane della carne.");
        }
    }
    enum AnimalType
    {
        Carnivore,
        Herbivore
    }
    class AnimalFactory
    {
        public Animal Create(AnimalType animalType, string name)
        {
            switch (animalType)
            {
                case AnimalType.Carnivore:
                    return new Carnivore(name);
                default:
                case AnimalType.Herbivore:
                    return new Herbivore(name);
            }
        }
    }
    abstract class Food
    {

    }
    class Grass : Food
    {

    }
    class Meat : Food { }
    abstract class Animal
    {
        private protected Food Food;
        public string Name { get; }
        public Animal(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return $"Ciao sono Noè ed ho dato da mangiare all'animale {this.GetType().Name} {this.Name} dell'{this.Food.GetType().Name}.";
        }
    }
    class Herbivore : Animal
    {
        public Herbivore(string name) : base(name)
        {
            this.Food = new Grass();
        }
    }
    class Carnivore : Animal
    {
        public Carnivore(string name) : base(name)
        {
            this.Food = new Meat();
        }
    }
}
