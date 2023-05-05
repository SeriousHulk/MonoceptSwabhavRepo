using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLib.Model;

namespace TicTacToeTestCases
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Constructor_CurrentPlayerShouldbePlayer_0_atStart()
        {
            Player p1 = new Player { MarkType = MarkType.X, Name = "Player 1" };
            Player p2 = new Player { MarkType = MarkType.O, Name = "Player 2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            Game game = new Game(board, resultAnalyser, players);
            Assert.AreEqual(p1, game.CurrentPlayer);
        }
        [TestMethod]
        public void Constructor_WhenGameIsStartedStatusShouldBeNoResult()
        {
            Player p1 = new Player { MarkType = MarkType.X, Name = "Player 1" };
            Player p2 = new Player { MarkType = MarkType.O, Name = "Player 2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            Game game = new Game(board, resultAnalyser, players);
            foreach (Cell cell in board.Cells)
            {
                Debug.Write(cell.Mark + "\t");
            }
            Assert.IsTrue(game.Status == ResultType.No_Result);
        }
        [TestMethod]
        public void Constructor_WhenGameIsEndedWithNoWinnerStatusShouldBeDraw()
        {
            Player p1 = new Player { MarkType = MarkType.X, Name = "Player 1" };
            Player p2 = new Player { MarkType = MarkType.O, Name = "Player 2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            Game game = new Game(board, resultAnalyser, players);
            game.Play(1);
            game.Play(4);
            game.Play(5);
            game.Play(0);
            game.Play(3);
            game.Play(2);
            game.Play(6);
            game.Play(7);
            game.Play(8);
            Debug.WriteLine(game.Status);
            Assert.IsTrue(game.Status == ResultType.Draw);
        }
        [TestMethod]
        public void Play_CallPlayWithCellPositionAndRetriveTheCell()
        {
            Player p1 = new Player { MarkType = MarkType.X, Name = "Player 1"};
            Player p2 = new Player { MarkType = MarkType.O, Name = "Player 2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            Game game = new Game(board, resultAnalyser, players);
            Assert.AreEqual(p1, game.CurrentPlayer);
        }
        [TestMethod]
        public void Play_AfterPlayIsCalledOncePlayerShouldChangeToPlayer1()
        {
            Player p1 = new Player { MarkType = MarkType.X, Name = "Player 1" };
            Player p2 = new Player { MarkType = MarkType.O, Name = "Player 2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            Game game = new Game(board, resultAnalyser, players);
            game.Play(4);
            Assert.AreEqual(players[1], game.CurrentPlayer);
        }
        [TestMethod]
        public void Play_AfterPlayIsCalledTwicePlayerShouldChangeToPlayer0()
        {
            Player p1 = new Player { MarkType = MarkType.X, Name = "Player 1" };
            Player p2 = new Player { MarkType = MarkType.O, Name = "Player 2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            Game game = new Game(board, resultAnalyser, players);
            game.Play(4);
            game.Play(3);
            Assert.AreEqual(players[0], game.CurrentPlayer);
        }
        [TestMethod]
        public void Play_AfterPlayCheckBoardIsUpdated()
        {
            Player p1 = new Player { MarkType = MarkType.X, Name = "Player 1" };
            Player p2 = new Player { MarkType = MarkType.O, Name = "Player 2" };
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            Game game = new Game(board, resultAnalyser, players);
            game.Play(4);
            Assert.IsTrue(board.Cells[4].Mark == players[0].MarkType);
        }
    }
}
