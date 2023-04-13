namespace TicTacToeApp
{
    class Program
    {
        static char[] board = new char[9];
        static int turns = 0;
        static char choice = 'y';
        static void Main(string[] args)
        {
            do
            {
                StartGame();
                while (true)
                {
                    DrawBoard();
                    int move;
                    string currentPlayer = (turns % 2 == 0) ? "Player 1" : "Player 2";
                    do
                    {
                        Console.Write($"{currentPlayer}, " +
                            $"enter move number (0-8) for your mark: ");
                    } while (!int.TryParse(Console.ReadLine(), out move) 
                    || move < 0 || move > 8 || board[move] != ' ');
                    board[move] = (turns % 2 == 0) ? 'O' : 'X';
                    turns++;
                    if (IsWinningMove())
                    {
                        DrawBoard();
                        Console.WriteLine($"{currentPlayer} wins!");
                        Console.WriteLine("Do you want to play again?");
                        break;
                    }
                    if (turns == 9)
                    {
                        DrawBoard();
                        Console.WriteLine("It's a draw!");
                        Console.WriteLine("Do you want to play again?");
                        break;
                    }
                }
                Console.Write("Play again? (y/n): ");
            } 
            while (Console.ReadLine().ToLower() == "y");
            Console.WriteLine("Press any key to exit...");
        }

        static void StartGame()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = ' ';
            }
        }

        static void DrawBoard()
        {
            Console.WriteLine($" 0-{board[0]}  1-{board[1]}  2-{board[2]} ");
            Console.WriteLine($" 3-{board[3]}  4-{board[4]}  5-{board[5]} ");
            Console.WriteLine($" 6-{board[6]}  7-{board[7]}  8-{board[8]} ");
            Console.WriteLine();
        }

        static bool IsWinningMove()
        {
            char mark = (turns % 2 == 0) ? 'X' : 'O';
            if (board[0] == mark && board[1] == mark && board[2] == mark ||
                board[3] == mark && board[4] == mark && board[5] == mark ||
                board[6] == mark && board[7] == mark && board[8] == mark)
            {
                return true;
            }
            if (board[0] == mark && board[3] == mark && board[6] == mark ||
                board[1] == mark && board[4] == mark && board[7] == mark ||
                board[2] == mark && board[5] == mark && board[8] == mark)
            {
                return true;
            }
            if (board[0] == mark && board[4] == mark && board[8] == mark ||
                board[2] == mark && board[4] == mark && board[6] == mark)
            {
                return true;
            }
            return false;
        }
    }
}