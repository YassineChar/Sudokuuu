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
        static int[,] originalBoard = new int[9, 9];
        static void Main(string[] args)
        {
<<<<<<< HEAD

=======
            InitializeBoard();
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
        static void InitializeBoard()
        {
            board = new int[,]
            {
            {5, 3, 0, 0, 7, 0, 0, 0, 0},
            {6, 0, 0, 1, 9, 5, 0, 0, 0},
            {0, 9, 8, 0, 0, 0, 0, 6, 0},
            {8, 0, 0, 0, 6, 0, 0, 0, 3},
            {4, 0, 0, 8, 0, 3, 0, 0, 1},
            {7, 0, 0, 0, 2, 0, 0, 0, 6},
            {0, 6, 0, 0, 0, 0, 2, 8, 0},
            {0, 0, 0, 4, 1, 9, 0, 0, 5},
            {0, 0, 0, 0, 8, 0, 0, 7, 9}
            };
>>>>>>> origin
        }
    }
}
