using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.CarFactory
{
    class CarFactory
    {
        public Car Create(Owner owner, Data data, string type)
        {
            Car car = default;
            switch (type)
            {
                case "1":
                    car = new Suv();
                    break;
                default:
                case "2":
                    car = new Coupe();
                    break;
            }
            car.Owner = owner;
            car.Data = data;
            return car;
        }
    }
    class Owner
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
    class Data
    {
        public string Plate { get; set; }
        public override string ToString()
        {
            return this.Plate;
        }
    }
    abstract class Car
    {
        public Owner Owner { get; set; }
        public Data Data { get; set; }
        private protected abstract string Addon { get; }
        public override string ToString()
        {
            return $"Abbiamo immatricolato la macchina {this.GetType().Name} {this.Data} {Addon} di {this.Owner}";
        }
    }
    interface IColorable
    {
        string Color { get; set; }
    }
    interface ICilindrable
    {
        int Cilinder { get; set; }
    }
    class Suv : Car, ICilindrable, IColorable
    {
        public int Cilinder { get; set; }
        public string Color { get; set; }
        private protected override string Addon => $"color:{Color} cc{Cilinder}";
    }
    class Coupe : Car, IColorable
    {
        public string Color { get; set; }
        private protected override string Addon => $"color: {Color}";
    }
}
