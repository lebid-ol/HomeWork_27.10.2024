using System.Text;

namespace HomeWork_27._10._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Car car = new Car("Грузовик", 140, 120.0, 2);
            Motorcycle motorcycle = new Motorcycle("BMW s1000 rr", 299, 116.5, true);
            Helicopter helicopter = new Helicopter("Apache", 293, 1150, 2);
            Ship ship = new Ship("Titanic", 41, 4722143, 46328);
            Yacht yacht = new Yacht("Beneteau Oceanis 41", 60, 10000, 7);
            Snowmobile snowmobile = new Snowmobile ("Yamaha", 120, 40, false);





        }

        public abstract class Vehicle
        {

            public string Name { get; set; }
            public int MaxSpeed { get; set; }
            public double FuelCapacity { get; set; }


            public  Vehicle (string name, int maxSpeed, double fuelCapacity)
            {
                Name = name;
                MaxSpeed = maxSpeed;
                FuelCapacity = fuelCapacity;
            }

            public abstract void StartEngine();


            public abstract void StopEngine();
            
            void Refuel(double liters)
            {
                double remainder = FuelCapacity - liters;

                double intoGasTank = 0;

                if (remainder < 0)
                {
                    Console.WriteLine($"Бак переполнен. Вместимость бака на текущий момент не более {FuelCapacity} литров.");

                    return;
                }
                else
                {
                   FuelCapacity = remainder; 
                    intoGasTank +=  liters;
                    Console.WriteLine($"Бак успешно заправлен. Текущий уровень топлива: {intoGasTank} литров.");
                }

                
            }

        }

    }
}

