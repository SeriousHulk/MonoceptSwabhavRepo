using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLib.Model;

namespace TicTacToeTestCases
{
    [TestClass]
    public class ResultAnalyserTest
    {
        [TestMethod]
        public void AnalyzeShouldResultNoResultForEmptyBoard()
        {
            Board board = new Board();
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            ResultType result = resultAnalyser.Analyze();
            Assert.IsTrue(result == ResultType.No_Result);
        }
        [TestMethod]
        public void Analyze_ShouldShowResultWinForVerticallySameX()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.X;
            board.Cells[3].Mark = MarkType.X;
            board.Cells[6].Mark = MarkType.X;
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            ResultType result = resultAnalyser.Analyze();
            Assert.IsTrue(result == ResultType.Win);
        }
        [TestMethod]
        public void ShouldShowResultWinForVerticallySameO()
        {
            Board board = new Board();
            board.Cells[0].Mark = MarkType.O;
            board.Cells[3].Mark = MarkType.O;
            board.Cells[6].Mark = MarkType.O;
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            ResultType result = resultAnalyser.Analyze();
            Assert.IsTrue(result == ResultType.Win);
        }
        [TestMethod]
        public void Analyze_ShouldShowResultWinForVerticallySameX_ForColumn2()
        {
            Board board = new Board();
            board.Cells[1].Mark = MarkType.X;
            board.Cells[4].Mark = MarkType.X;
            board.Cells[7].Mark = MarkType.X;
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            ResultType result = resultAnalyser.Analyze();
            Assert.IsTrue(result == ResultType.Win);
        }
        [TestMethod]
        public void Analyze_ShouldShowResultWinForVerticallySameX_ForColumn3()
        {
            Board board = new Board();
            board.Cells[2].Mark = MarkType.X;
            board.Cells[5].Mark = MarkType.X;
            board.Cells[8].Mark = MarkType.X;
            ResultAnalyser resultAnalyser = new ResultAnalyser(board);
            ResultType result = resultAnalyser.Analyze();
            Assert.IsTrue(result == ResultType.Win);
        }
        [TestMethod]
        public void ShouldShowResultWinForHorizontallySameX()
        {

        }
        [TestMethod]
        public void ShouldShowResultWinForHorizontallySameO()
        {

        }
    }
}
