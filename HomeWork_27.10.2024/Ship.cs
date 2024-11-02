using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
    internal class Ship : Program.Vehicle
    {
        public int CargoCapacity { get; set; }
        public Ship(string name, int maxSpeed, double fuelCapacity, double intoGasTank, int cargoCapacity) : base(name, maxSpeed, fuelCapacity, intoGasTank)
        {
            CargoCapacity = cargoCapacity;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Мотор корабля работает");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Мотор корабля заглушен");
        }

        internal void LoadCargo()
        {
            Console.WriteLine("Загрузка судна");
        }
        internal void UnloadCargo()
        {
            Console.WriteLine("Разгрузка судна");
        }
    }
}
