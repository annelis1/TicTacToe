using TikTakToe;

support_class sc =  new support_class();

//variables
int player_1 = 0;

//welcome the user to the game
Console.WriteLine("Welcome to Tic-Tac-Toe!");

// array for choices
int [] board = new int[9];
for (int i = 0; i < 9; i++)
{ 
    board[i] = i + 1; 
}

//print board
Console.WriteLine("Current board: ");
sc.printBoard();
bool winner = false;
while (winner == false) {
    while (true)
    {
        Console.WriteLine("Player 1's Turn. Select a number");
        string input = Console.ReadLine();

        if (int.TryParse(input, out player_1) && player_1 >= 1 && player_1 <= 9)
        {
            break;
        }

        Console.WriteLine("Invalid input. Please enter a valid available position.")

    }

    for (int i = 0; i < 9; i++)
    {
        if (board[i] == player_1)
        {
            board[i] = 'X';
        }
    }
    //check for winners
    sc.checkWinner();
    Console.WriteLine("Board: ");
    sc.printBoard();

    while (true)
    {
        Console.WriteLine("Player 2's Turn. Select a number");
        string input = Console.ReadLine();

        if (int.TryParse(input, out player_1) && player_1 >= 1 && player_1 <= 9)
        {
            break;
        }

        Console.WriteLine("Invalid input. Please enter a valid available position.")

    }

    for (int i = 0; i < 9; i++)
    {
        if (board[i] == player_1)
        {
            board[i] = 'O';
        }
    }
    sc.checkWinner();
    Console.WriteLine("Board: ");
    sc.printBoard();
}

//End the game and announce winner
if (winner)
{
    Console.WriteLine("Game Over!");
}
