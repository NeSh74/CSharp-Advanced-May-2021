using System;
using System.IO;
using System.Linq;

namespace _2_Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = File.ReadAllLines("text.txt");

            for (int i = 0; i < line.Length; i++)
            {
                string currLine = line[i];
                int letterCount = CountOfLetters(currLine);
                int punktionalCount = PunktionalCharCount(currLine);

                line[i] = $"Line {i + 1}: {currLine}. ({letterCount})({punktionalCount})";
            }
            File.WriteAllLines("../../../output.txt", line);

        }

        static int PunktionalCharCount(string currLine)
        {
            //char[] punktionalMarks = { '-', ',', '.', '!', '?' };
            int count = 0;
            for (int i = 0; i < currLine.Length; i++)
            {
                char currentChar = currLine[i];
                if (char.IsPunctuation( currentChar))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountOfLetters(string currLine)
        {
            int count = 0;
            for (int i = 0; i < currLine.Length; i++)
            {
                char currChar = currLine[i];
                if (char.IsLetter(currChar))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
