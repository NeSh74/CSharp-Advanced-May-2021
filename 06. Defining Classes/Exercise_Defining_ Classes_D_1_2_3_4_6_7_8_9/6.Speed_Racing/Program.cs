using System;
using System.Linq;

namespace _6.Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new Car [n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var tokens = input.Split(new char[0],StringSplitOptions.RemoveEmptyEntries);
                var model = tokens[0];
                var fuelAmount = double.Parse(tokens[1]);
                var fuelCost = double.Parse(tokens[2]);
                cars[i] = new Car(model, fuelAmount, fuelCost);
            }

            while (true )
            {
                var input = Console.ReadLine();
                var tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (input =="End")
                {
                    break;
                }

                var model = tokens[1];
                double distance = double.Parse(tokens[2]);
                cars.Where(c => c.Model == model).ToList().ForEach(c=>c.Drive(distance));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
