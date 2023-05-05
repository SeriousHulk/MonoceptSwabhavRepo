using TicTacToeLib.Model;

namespace WinFormsAppTicTac
{
    public partial class Form1 : Form
    {
        Board board;
        ResultAnalyser resultAnalyser;
        Game game;
        Player p1;
        Player p2;
        Player[] players;
        Label currentPlayer;
        Label gameStatus;
        public Form1()
        {
            p1 = new Player { MarkType = MarkType.X, Name = "Player 1" };
            p2 = new Player { MarkType = MarkType.O, Name = "Player 2" };
            players = new Player[] { p1, p2 };
            board = new Board();
            resultAnalyser = new ResultAnalyser(board);
            game = new Game(board, resultAnalyser, players);
            label3 = currentPlayer;
            label4 = currentPlayer;
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text; label4.Text = textBox2.Text;
            p1 = new Player { MarkType = MarkType.X, Name = textBox1.Name };
            p2 = new Player { MarkType = MarkType.O, Name = textBox2.Name };
        }
        private void button_Click(object sender, EventArgs e)
        {
                Button button = sender as Button;
                int cellPosition = Convert.ToInt32(button.Text);
                string currentPlayer1 = game.CurrentPlayer.MarkType.ToString();
                game.Play(cellPosition);
                button.Text = currentPlayer1;
                label5.Text = "Game Status :" + game.Status + "\n Current Player:" + game.CurrentPlayer.Name;
                button.Enabled = false;
                button.BackColor = Color.LightBlue;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}