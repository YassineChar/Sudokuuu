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
            InitializeBoard();
            PrintBoard();
            while (!IsSudokuSolved())
            {
                int row, col, num;
                do
                {
                    Console.Write("Inserisci riga (1-9): ");
                    row = int.Parse(Console.ReadLine()) - 1; Console.Write("Inserisci colonna (1-9): ");
                    col = int.Parse(Console.ReadLine()) - 1;
                    if (originalBoard[row, col] != 0)
                    {
                        Console.WriteLine("Impossibile modificare un numero fissato.");
                        continue;
                    }
                    Console.Write("Inserisci numero (1-9): ");
                    num = int.Parse(Console.ReadLine());
                } while (!IsValidMove(row, col, num));
                board[row, col] = num; PrintBoard();
            }
            Console.WriteLine("Complimenti, hai risolto il Sudoku!");


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
        }
        static bool IsSudokuSolved()
        {
            // Verifica se il Sudoku è risolto
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == 0)
                        return false;
                }
            }
            return true;
        }
        static bool IsBoxSafe(int startRow, int startCol, int num)
        {
            // Verifica se il numero è già presente nella sottogriglia 3x3
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[startRow + i, startCol + j] == num)
                        return false;
                }
            }
            return true;
        }
        static bool IsColumnSafe(int col, int num)
        {
            // Verifica se il numero è già presente nella colonna
            for (int i = 0; i < 9; i++)
            {
                if (board[i, col] == num)
                    return false;
            }
            return true;

        }
        static bool IsRowSafe(int row, int num)
        {
            // Verifica se il numero è già presente nella riga
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == num)
                    return false;
            }
            return true;
        }
        static bool IsValidMove(int row, int col, int num)
        {
            // Verifica se il numero può essere inserito nella posizione desiderata
            return IsRowSafe(row, num) && IsColumnSafe(col, num) && IsBoxSafe(row - row % 3, col - col % 3, num);
        }

    }
}
