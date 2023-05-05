using System.Windows.Forms;
using TicTacToeLib.Model;

namespace TicTacToeWinForm
{
    public partial class Form1 : Form
    {
        private Game _game;

        public Form1()
        {
            //InitializeComponent();
            Board board = new Board();
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            Player[] players = new Player[] { new Player { MarkType = MarkType.X }, new Player { MarkType = MarkType.O } };
            _game = new Game(board, resultAnalyser, players);
            UpdateBoard();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // Get the cell position from the button's Tag property
            int cellPosition = Convert.ToInt32((sender as Button).Tag);

            // Mark the cell and switch to the next player
            _game.Play(cellPosition);

            // Display the state of the board
            UpdateBoard();

            // Check the result of the game
            if (_game.Status == ResultType.Win)
            {
                MessageBox.Show(_game.CurrentPlayer.MarkType + " wins!");
                ResetGame();
            }
            else if (_game.Status == ResultType.Draw)
            {
                MessageBox.Show("Draw!");
                ResetGame();
            }
        }

        private void UpdateBoard()
        {
            // Update the text of the buttons to reflect the state of the board
            for (int i = 0; i < 9; i++)
            {
                buttonArray[i].Text = _game.Board.Cells[i].Mark.ToString();
            }
        }

        private void ResetGame()
        {
            // Reset the game to its initial state
            _game = new Game(new Board(), new ResultAnalyser(board), players);
            UpdateBoard();
        }
    }
}
