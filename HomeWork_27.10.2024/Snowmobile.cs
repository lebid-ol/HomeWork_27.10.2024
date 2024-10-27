using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
    internal class Snowmobile : Program.Vehicle
    {
        public bool HasHeatedSeats { get; set; }
        public Snowmobile(string name, int maxSpeed, double fuelCapacity, bool hasHeatedSeats) : base(name, maxSpeed, fuelCapacity)
        {
            HasHeatedSeats = hasHeatedSeats;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Мотор снегохода работает");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Мотор снегохода заглушен");
        }

        internal void DriveOnSnow()
        {
            Console.WriteLine("Езда по снегу");
        }
    }
}
