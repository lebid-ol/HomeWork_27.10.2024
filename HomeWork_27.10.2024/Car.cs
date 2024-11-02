using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
    internal class Car : Program.Vehicle
    {
        public int NumberOfDoors { get; set; }
        public Car(string name, int maxSpeed, double fuelCapacity, double intoGasTank, int numberOfDoors) : base(name, maxSpeed, fuelCapacity, intoGasTank)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Мотор автомобиля работает");
        }

        public override  void StopEngine()
        {
            Console.WriteLine("Мотор автомобиля заглушен");
        }

        internal void Honk ()
        {
            Console.WriteLine("Автомобиль издает звук");
        }

    }
}
