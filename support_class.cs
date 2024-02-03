using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac2
{
    class Support_Class
    {
        // Method to print the game board
        public void PrintBoard(char[,] board)
        {
            Console.WriteLine("       ");
            Console.WriteLine("  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("  -----");
            Console.WriteLine("  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("  -----");
            Console.WriteLine("  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
        }


        // Method to check for a winner
        public static char CheckWinner(char[,] board)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                {
                    return board[i, 0];
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[0, j] != ' ')
                {
                    return board[0, j];
                }
            }

            // Check diagonals
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ') ||
                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' '))
            {
                return board[1, 1];
            }

            // Check for tie
            bool isTie = true;
            foreach (char cell in board)
            {
                if (cell == ' ')
                {
                    isTie = false;
                    break;
                }
            }
            if (isTie)
                return 'T';

            return ' ';
        }
    }

}
