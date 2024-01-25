using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku6
{
    internal class Program
    {
        static int[,] board = new int[9, 9];
        static void Main(string[] args)
        {
            PrintBoard();
            Console.ReadKey();
        }
        static void PrintBoard()
        {
            Console.WriteLine(" -----------------------");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j] == 0 ? "  " : $"{board[i, j]} ");
                    if (j % 3 == 2) Console.Write("| ");
                }
                Console.WriteLine();
                if (i % 3 == 2) Console.WriteLine(" -----------------------");
            }
        }
    }
}
