using System.Reflection;
using static _04VehicleCatalogue.Program;

namespace _04VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            VehicleCatalog cataloge = new VehicleCatalog();

            while (input != "end")
            {
                string[] vechile = input.Split("/");
                string vechileType = vechile[0];
                string brand = vechile[1];
                string model = vechile[2];
                int horsePowerOrWeight = int.Parse(vechile[3]);

                if (vechileType == "Truck")
                {
                    Truck truck = new Truck(brand, model, horsePowerOrWeight);

                    cataloge.Trucks.Add(truck);
                }
                else if (vechileType == "Car")
                {
                    Car car = new Car(brand, model, horsePowerOrWeight);

                    cataloge.Cars.Add(car);
                }

                input = Console.ReadLine();
            }
            if (cataloge.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (var car in cataloge.Cars.OrderBy(cataloge => cataloge.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (cataloge.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in cataloge.Trucks.OrderBy(cataloge => cataloge.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
        public class Car
        {
            public Car(string brand, string model, int horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }

            public string Brand { get; set; }

            public string Model { get; set; }

            public int HorsePower { get; set; }
        }
        public class Truck
        {
            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }

            public string Brand { get; set; }

            public string Model { get; set; }

            public int Weight { get; set; }
        }
        public class VehicleCatalog
        {
            public List<Car> Cars { get; set; } = new List<Car>();

            public List<Truck> Trucks { get; set; } = new List<Truck>();
        }
    }
}