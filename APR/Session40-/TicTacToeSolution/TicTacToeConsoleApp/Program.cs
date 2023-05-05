using TicTacToeLib.Model;

namespace TicTacToeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player { MarkType = MarkType.X, Name = "Player 1" };
            Player p2 = new Player { MarkType = MarkType.O, Name = "Player 2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            Game game = new Game(board, resultAnalyser, players);
            game.Play(4);
            PrintBoard(board);
        }

        private static void PrintBoard(Board board)
        {
            int row = 0;
            foreach (Cell cell in board.Cells)
            {
                row++;
                Console.Write(cell.Mark + "\t");
                if (row == 3 || row == 6)
                {
                Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}