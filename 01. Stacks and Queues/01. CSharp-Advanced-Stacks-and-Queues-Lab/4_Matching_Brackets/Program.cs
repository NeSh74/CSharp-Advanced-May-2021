using System;
using System.Collections.Generic;

namespace _4_Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> bracketsInd = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracketsInd.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIdx = bracketsInd.Pop();
                    Console.WriteLine(input.Substring(startIdx, i - startIdx + 1));
                }
            }
        }
    }
}
