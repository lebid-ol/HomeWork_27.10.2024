using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_27._10._2024
{
    internal class Yacht : Program.Vehicle
    {
        public int NumberOfCabins { get; set; }
        public Yacht(string name, int maxSpeed, double fuelCapacity, int numberOfCabins) : base(name, maxSpeed, fuelCapacity)
        {
            NumberOfCabins = numberOfCabins;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Мотор яхты работает");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Мотор яхты заглушен");
        }

        internal void DropAnchor()
        {
            Console.WriteLine("Якорь опущен");
        }
        internal void RaiseAnchor()
        {
            Console.WriteLine("Якорь поднят");
        }
    }
}
