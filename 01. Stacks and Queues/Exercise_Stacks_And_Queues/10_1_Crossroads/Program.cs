using System;
using System.Collections.Generic;

namespace _10_1_Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            int summedDuration = greenLightDuration + freeWindowDuration;

            Queue<char> car = new Queue<char>();
            Queue<Queue<char>> cars = new Queue<Queue<char>>();

            int passedCarsCounter = 0;
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "green")
                {
                    int currentGreenLightDuration = greenLightDuration;
                    while (cars.Count > 0)
                    {
                        Queue<char> passingCar = cars.Dequeue();
                        string carsName = string.Join("", passingCar);
                        currentGreenLightDuration -= passingCar.Count;
                        while (passingCar.Count > 0)
                        {
                            summedDuration--;
                            char currentLetter = passingCar.Dequeue();
                            if (summedDuration < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{carsName} was hit at {currentLetter}.");
                                return;
                            }
                        }
                        passedCarsCounter++;

                        if (currentGreenLightDuration <= 0)
                        {
                            break;
                        }
                    }
                    summedDuration = greenLightDuration + freeWindowDuration;
                    continue;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    car.Enqueue(input[i]);
                }

                cars.Enqueue(car);
                car = new Queue<char>();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCarsCounter} total cars passed the crossroads.");
        }
    }
}
