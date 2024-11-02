using System.Text;

namespace HomeWork_27._10._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Car car = new Car("Грузовик", 140, 120.0, 81.0, 2);
            Motorcycle motorcycle = new Motorcycle("BMW s1000 rr", 299, 12, 7, true);
            Helicopter helicopter = new Helicopter("Apache", 293, 1150, 700, 2);
            Ship ship = new Ship("Titanic", 41, 4722143, 4500000, 46328);
            Yacht yacht = new Yacht("Beneteau Oceanis 41", 60, 10000, 600, 7);
            Snowmobile snowmobile = new Snowmobile ("Yamaha", 120, 40, 37, false);
            car.StartEngine();
            car.StopEngine();
            motorcycle.Wheelie();
            helicopter.TakeOff();
            ship.UnloadCargo();
            yacht.StopEngine();
            snowmobile.DriveOnSnow();

            Vehicle[] vehicles = new Vehicle[6];
            vehicles[0] = car;
            vehicles[1] = motorcycle;
            vehicles[2] = helicopter;
            vehicles[3] = ship;
            vehicles[4] = snowmobile;
            vehicles[5] = yacht;

            Console.WriteLine("________________________________________");
            Console.WriteLine("Полиморфизм");

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.StartEngine();
                vehicle.Refuel(5);
            }


        }

        public abstract class Vehicle
        {

            public string Name { get; set; }
            public int MaxSpeed { get; set; }
            public double FuelCapacity { get; set; }
            public double IntoGasTank { get; set; }


            public  Vehicle (string name, int maxSpeed, double fuelCapacity, double intoGasTank)
            {
                Name = name;
                MaxSpeed = maxSpeed;
                FuelCapacity = fuelCapacity;
                IntoGasTank = intoGasTank;
            }

            public abstract void StartEngine();


            public abstract void StopEngine();
            
           public  void Refuel(double liters)
            {
                
               if (IntoGasTank + liters > FuelCapacity)
                {
                    Console.WriteLine($"Бак переполнен. Вместимость бака {FuelCapacity} литров. На текущий момент до полного бака осталось {FuelCapacity - IntoGasTank} литров");

                    return;
                }
                else
                {
                    IntoGasTank +=  liters;
                    Console.WriteLine($"Бак успешно заправлен. Текущий уровень топлива: {IntoGasTank} литров.");
                }

                
            }

        }

    }
}

