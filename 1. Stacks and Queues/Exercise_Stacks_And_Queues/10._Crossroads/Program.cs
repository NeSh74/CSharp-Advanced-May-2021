using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int secondsToPassCrossroad = int.Parse(Console.ReadLine());
            Queue<string> carQueue = new Queue<string>();
            int totalCarsPassed = 0;

            while (true)
            {
                string cmd = Console.ReadLine();
                int greenLight = greenLightSeconds;
                int passSeconds = secondsToPassCrossroad;
                if (cmd == "END")
                {
                    Console.WriteLine($"Everyone is safe.{Environment.NewLine}" +
                                      $"{totalCarsPassed} total cars passed the crossroads.");
                    return;
                }

                if (cmd == "green")
                {
                    while (greenLight > 0 && carQueue.Count != 0)
                    {
                        string firstInQueue = carQueue.Dequeue();
                        greenLight -= firstInQueue.Length;
                        if (greenLight > 0)
                        {
                            totalCarsPassed++;
                        }
                        else
                        {
                            passSeconds += greenLight;
                            if (passSeconds < 0)
                            {
                                Console.WriteLine($"A crash happened!{Environment.NewLine}" +
                                                  $"{firstInQueue} was hit at {firstInQueue[firstInQueue.Length + passSeconds]}.");
                                return;
                            }

                            totalCarsPassed++;
                        }
                    }
                }
                else
                {
                    carQueue.Enqueue(cmd);
                }
            }
        }
    }
}
