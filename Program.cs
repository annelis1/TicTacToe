using System;
using TicTac2;

//Tristan McLaughlin, Sara Olivera, Annelise Anderson, Seth Alley
//This is a tic tac toe program
class Driver
{
    static Support_Class sc = new Support_Class();

    static void Main(string[] args)
    {
        char[,] board = new char[3, 3]; // game board array
        char currentPlayer = 'X'; // indicates current player: X or O
        bool gameEnded = false;

        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        Console.WriteLine("Enter a number for where you would like to place your piece");
        Console.WriteLine("  1|2|3\n  -----\n  4|5|6\n  -----\n  7|8|9");

        // Initialize board
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }

        while (!gameEnded)
        {
            Console.WriteLine("Player " + currentPlayer + ", enter your move (1-9):");
            if (!int.TryParse(Console.ReadLine(), out int move) || move < 1 || move > 9 || !PlaceMove(board, move, currentPlayer))
            {
                Console.WriteLine("Invalid move. Please try again.");
                continue;
            }

            sc.PrintBoard(board);

            char winner = Support_Class.CheckWinner(board);
            if (winner != ' ')
            {
                if (winner == 'T')
                {
                    Console.WriteLine("It's a tie!");
                }
                else
                {
                    Console.WriteLine("Player " + winner + " wins!");
                }
                gameEnded = true;
            }
            else
            {
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }
        }
    }

    static bool PlaceMove(char[,] board, int move, char currentPlayer)
    {
        int row = (move - 1) / 3;
        int col = (move - 1) % 3;

        if (board[row, col] == ' ')
        {
            board[row, col] = currentPlayer;
            return true;
        }

        return false;
    }
}