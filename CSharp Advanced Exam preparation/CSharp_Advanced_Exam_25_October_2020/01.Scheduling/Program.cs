using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            //var task = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            //var threads = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            //var taskToBeKilled = int.Parse(Console.ReadLine());

            //while (true)
            //{
            //    if (task.Peek() == taskToBeKilled)
            //    {
            //        break;
            //    }

            //    if (task.Peek() <= threads.Peek())
            //    {
            //        task.Pop();
            //        threads.Dequeue();
            //    }
            //    else
            //    {
            //        threads.Dequeue();
            //    }
            //}

            //Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskToBeKilled}");
            //Console.WriteLine(string.Join(" ", threads));

            var task = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            var threads = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            var taskToBeKilled = int.Parse(Console.ReadLine());

            while (task.Peek() != taskToBeKilled)
            {
                if (task.Peek() <= threads.Peek())
                {
                    task.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskToBeKilled}");
            Console.WriteLine(string.Join(" ", threads));

        }
    }
}
