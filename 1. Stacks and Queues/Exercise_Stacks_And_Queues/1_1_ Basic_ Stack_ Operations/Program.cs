using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_1__Basic__Stack__Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = commands[0];
            int s = commands[1];
            int x = commands[2];
            Stack<int> stack = new Stack<int>();
            PushElements(stack, numbers, n);
            PopElements(stack, s);
            Checks(stack, x);
            //for (int i = 0; i < n ; i++)
            //{
            //    stack.Push(numbers[i]);
            //}

            //for (int i = 0; i < s; i++)
            //{
            //    stack.Pop();
            //}

            //    if (stack .Any( ))
            //    {
            //        if (stack .Contains( x))
            //        {
            //            Console.WriteLine("true");
            //        }
            //        else
            //        {
            //            Console.WriteLine(stack.Min());
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(0);
            //    }
            //}

            static Stack<int> PushElements(Stack<int> stack, int[] numbers, int command)
            {
                for (int i = 0; i < command; i++)
                {
                    stack.Push(numbers[i]);
                }

                return stack;
            }

            static Stack<int> PopElements(Stack<int> stack, int command)
            {
                for (int i = 0; i < command; i++)
                {
                    stack.Pop();
                }

                return stack;
            }

            static void Checks(Stack<int> stack, int command)
            {
                if (stack.Any())
                {
                    if (stack.Contains(command))
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
