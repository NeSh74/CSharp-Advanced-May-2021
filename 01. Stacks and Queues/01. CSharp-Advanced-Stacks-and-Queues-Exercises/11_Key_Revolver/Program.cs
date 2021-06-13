using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunbarrelSize = int.Parse(Console.ReadLine());

            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(bulletsInput);
            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(locksInput);

            int inteligenceValue = int.Parse(Console.ReadLine());
            int bulletsCount = 0;
            int currBunbarrelSize = gunbarrelSize;
            while (bullets.Any() && locks.Any())
            {
                bulletsCount++;
                currBunbarrelSize--;
                int currBullet = bullets.Pop();
                int currLock = locks.Peek();
                if (currBullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (currBunbarrelSize == 0 && bullets.Any())
                {
                    currBunbarrelSize = gunbarrelSize;
                    Console.WriteLine("Reloading!");
                }
            }

            if (!locks.Any())
            {
                int moneyEarned = inteligenceValue - (bulletsCount * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${ moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
