using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
    internal class Helicopter : Program.Vehicle
    {
        public int RotorBlades { get; set; }
        public Helicopter(string name, int maxSpeed, double fuelCapacity, double intoGasTank, int rotorBlades) : base(name, maxSpeed, fuelCapacity, intoGasTank)
        {
            RotorBlades = rotorBlades;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Мотор вертолета работает");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Мотор вертолета заглушен");
        }

        internal void TakeOff()
        {
            Console.WriteLine("Вертолет взлетел");
        }
        internal void Land()
        {
            Console.WriteLine("Вертолет приземлился");
        }

    }
}
