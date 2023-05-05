using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib.Model
{
    public class ResultAnalyser
    {
        private Board _board;
        public ResultAnalyser(Board board)
        {
            _board = board;
        }
        public Board Board { get { return _board; } }
        public ResultType Analyze() 
        {
            if (MatchVeritcal() || MatchHorizontal() || MatchDiagonal())
            {
                return ResultType.Win;
            }
            if (_board.IsBoardFull())
            {
                return ResultType.Draw;
            }
            return ResultType.No_Result; 
        }
        private bool CheckVerticallyForX()
        {
            if (_board.Cells[0].Mark == MarkType.X &&
                _board.Cells[3].Mark == MarkType.X &&
                _board.Cells[6].Mark == MarkType.X ||
                _board.Cells[1].Mark == MarkType.X &&
                _board.Cells[4].Mark == MarkType.X &&
                _board.Cells[7].Mark == MarkType.X ||
                _board.Cells[2].Mark == MarkType.X &&
                _board.Cells[5].Mark == MarkType.X &&
                _board.Cells[8].Mark == MarkType.X)
                return true;
            return false;
        }
        private bool CheckVerticallyForO()
        {
            if (_board.Cells[0].Mark == MarkType.O &&
                _board.Cells[3].Mark == MarkType.O &&
                _board.Cells[6].Mark == MarkType.O ||
                _board.Cells[1].Mark == MarkType.O &&
               _board.Cells[4].Mark == MarkType.O &&
               _board.Cells[7].Mark == MarkType.O ||
                _board.Cells[2].Mark == MarkType.O &&
                _board.Cells[5].Mark == MarkType.O &&
                _board.Cells[8].Mark == MarkType.O)
                return true;
            return false;
        }
        private bool CheckHorizontallyForX()
        {
            if (_board.Cells[0].Mark == MarkType.X &&
                _board.Cells[1].Mark == MarkType.X &&
                _board.Cells[2].Mark == MarkType.X ||
                _board.Cells[3].Mark == MarkType.X &&
                _board.Cells[4].Mark == MarkType.X &&
                _board.Cells[5].Mark == MarkType.X ||
                _board.Cells[6].Mark == MarkType.X &&
                _board.Cells[7].Mark == MarkType.X &&
                _board.Cells[8].Mark == MarkType.X)
                return true;
            return false;
        }
        private bool CheckHorizontallyForO()
        {
            if (_board.Cells[0].Mark == MarkType.O &&
                _board.Cells[1].Mark == MarkType.O &&
                _board.Cells[2].Mark == MarkType.O ||
                _board.Cells[3].Mark == MarkType.O &&
               _board.Cells[4].Mark == MarkType.O &&
               _board.Cells[5].Mark == MarkType.O ||
               _board.Cells[6].Mark == MarkType.O &&
                _board.Cells[7].Mark == MarkType.O &&
                _board.Cells[8].Mark == MarkType.O)
                return true;
            return false;
        }
        private bool CheckDiagoallyForX()
        {
            if (_board.Cells[0].Mark == MarkType.X &&
                _board.Cells[4].Mark == MarkType.X &&
                _board.Cells[8].Mark == MarkType.X ||
                _board.Cells[2].Mark == MarkType.X &&
                _board.Cells[4].Mark == MarkType.X &&
                _board.Cells[6].Mark == MarkType.X)
                return true;
            return false;
        }
        private bool CheckDiagoallyForO()
        {
            if (_board.Cells[0].Mark == MarkType.O &&
                _board.Cells[4].Mark == MarkType.O &&
                _board.Cells[8].Mark == MarkType.O ||
                _board.Cells[2].Mark == MarkType.O &&
               _board.Cells[4].Mark == MarkType.O &&
               _board.Cells[6].Mark == MarkType.O)
                return true;
            return false;
        }
        private bool MatchVeritcal()
        {
            if (CheckVerticallyForX() || CheckVerticallyForO())
                return true;
            return false;
        }
        private bool MatchHorizontal()
        {
            if (CheckHorizontallyForX() || CheckHorizontallyForO())
                return true;
            return false;
        }
        private bool MatchDiagonal()
        {
            if (CheckDiagoallyForX() || CheckDiagoallyForO())
                return true;
            return false;
        }
    }
}
