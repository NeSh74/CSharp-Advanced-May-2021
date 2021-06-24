using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _02.Book_Worm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            char[] initialWord = Console.ReadLine()
                .ToCharArray();
            Stack<char> word = new Stack<char>(initialWord);

            int n = int.Parse(Console.ReadLine());

            char[][] field = new char[n][];
            int playeRow = -1;
            int playeCol = -1;
            bool playerPositionFound = false;

            InitializeField(n, field, ref playeRow, ref playeCol, ref playerPositionFound);

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "up")
                {
                    if (playeRow - 1 >= 0)
                    {
                        playeRow--;
                        char symbol = field[playeRow][playeCol];
                        if (Char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playeRow][playeCol] = 'P';
                        field[playeRow + 1][playeCol] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
                else if (command == "down")
                {
                    if (playeRow + 1 < n)
                    {
                        playeRow++;
                        char symbol = field[playeRow][playeCol];
                        if (Char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playeRow][playeCol] = 'P';
                        field[playeRow - 1][playeCol] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
                else if (command == "left")
                {
                    if (playeCol - 1 >= 0)
                    {
                        playeCol--;
                        char symbol = field[playeRow][playeCol];
                        if (Char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playeRow][playeCol] = 'P';
                        field[playeRow][playeCol + 1] = '-';

                    }
                    else
                    {
                        Punish(word);
                    }
                }
                else if (command == "right")
                {
                    if (playeCol + 1 < n)
                    {
                        playeCol++;
                        char symbol = field[playeRow][playeCol];
                        if (Char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playeRow][playeCol] = 'P';
                        field[playeRow][playeCol - 1] = '-';

                    }
                    else
                    {
                        Punish(word);
                    }
                }
            }

            Console.WriteLine(string.Join("", word.Reverse()));
            PrintField(field);
        }

        private static void PrintField(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write(field[row][col]);
                }

                Console.WriteLine();
            }
        }

        private static void Punish(Stack<char> word)
        {
            if (word.Count > 0)
            {
                word.Pop();
            }
        }

        private static void InitializeField(int n, char[][] field, ref int playeRow, ref int playeCol, ref bool playerPosFound)
        {
            //int playeRow;
            //int playeCol;
            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                if (!playerPosFound)
                {
                    for (int col = 0; col < currentRow.Length; col++)
                    {
                        if (currentRow[col] == 'P')
                        {
                            playeRow = row;
                            playeCol = col;
                            playerPosFound = true;
                            break;
                        }
                    }
                }

                field[row] = currentRow;
            }
        }
    }
}
