using System.Xml.Linq;
using TicTacToeLib.Model;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Game _game;

        public Form1()
        {
            InitializeComponent();

            // Create a new instance of the Game class
            Board board = new Board();
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            Player[] players = new Player[] { new Player(MarkType.X), new Player(MarkType.O) };
            _game = new Game(board, resultAnalyser, players);

            // Display the state of the board
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
        private Button[] buttonArray;

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonArray = new Button[9];

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Width = 50;
                buttonArray[i].Height = 50;
                buttonArray[i].Location = new Point((i % 3) * 50, (i / 3) * 50);
                buttonArray[i].Tag = i;
                buttonArray[i].Click += new EventHandler(button_Click);
                Controls.Add(buttonArray[i]);
            }
        }
    }
}