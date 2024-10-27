using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
    internal class Motorcycle : Program.Vehicle
    {
        public bool HasSider { get; set; }
        public Motorcycle(string name, int maxSpeed, double fuelCapacity, bool hasSider) : base(name, maxSpeed, fuelCapacity)
        {
           HasSider = hasSider;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Мотор мотоцикла работает");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Мотор мотоцикла заглушен");
        }

        internal void Wheelie()
        {
            Console.WriteLine("Мотоцикл выполняет трюк вилли");
        }
    }
}
