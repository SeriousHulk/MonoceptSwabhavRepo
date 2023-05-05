using TicTacToeLib.Model;

namespace TicTacToeTestCases
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void Constructor_BoardShouldInitializeWith_9_EmptyCells()
        {
            Board board = new Board();
            Assert.IsTrue(board.Cells.Length == 9);
            for (int i = 0; i < board.Cells.Length; i++)
            {
                Assert.IsTrue(board.Cells[i].Mark == MarkType.Empty);
            }
        }
        [TestMethod]
        public void MarkCell_CellInBoardMustBeMarkedWithXorO()
        {
            Board board = new Board();
            board.MarkCell(cellPosition: 8, mark: MarkType.X);
            Assert.IsTrue(board.Cells[8].Mark == MarkType.X);
        }
        [TestMethod, ExpectedException(typeof(CellAlreadyMarkedException))]
        public void MarkCell_ShouldThrowExceptionIfSameCellPositionIsMarked()
        {
            Board board = new Board();
            board.MarkCell(cellPosition: 8, mark: MarkType.X);
            board.MarkCell(cellPosition: 8, mark: MarkType.X);
        }
        [TestMethod]
        public void IsBoardFull_shouldReturnTrueOnCalling()
        {
            Board board = new Board();
            for (int i = 0; i < board.Cells.Length; i++)
            {
                board.MarkCell(cellPosition: i, mark: MarkType.X);
            }
            Assert.IsTrue(board.IsBoardFull());
        }
    }
}