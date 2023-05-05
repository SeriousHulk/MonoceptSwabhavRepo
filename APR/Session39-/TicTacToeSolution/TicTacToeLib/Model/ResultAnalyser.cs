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
            if (_board.IsEmpty())
                return ResultType.No_Result;
            if (MatchVeritcal())
            {
                return ResultType.Win;
            }
            return ResultType.Draw; 
        }
        private bool CheckVerticallyForX()
        {
            if (_board.Cells[0].Mark == MarkType.X &&
                _board.Cells[3].Mark == MarkType.X &&
                _board.Cells[6].Mark == MarkType.X)
                return true;
            if (_board.Cells[1].Mark == MarkType.X &&
                _board.Cells[4].Mark == MarkType.X &&
                _board.Cells[7].Mark == MarkType.X)
                return true;
            if (_board.Cells[2].Mark == MarkType.X &&
                _board.Cells[5].Mark == MarkType.X &&
                _board.Cells[8].Mark == MarkType.X)
                return true;
            return false;
        }
        private bool CheckVerticallyForO()
        {
            if (_board.Cells[0].Mark == MarkType.O &&
                _board.Cells[3].Mark == MarkType.O &&
                _board.Cells[6].Mark == MarkType.O)
                return true;
            if (_board.Cells[1].Mark == MarkType.O &&
               _board.Cells[4].Mark == MarkType.O &&
               _board.Cells[7].Mark == MarkType.O)
                return true;
            if (_board.Cells[2].Mark == MarkType.O &&
                _board.Cells[5].Mark == MarkType.O &&
                _board.Cells[8].Mark == MarkType.O)
                return true;
            return false;
        }
        private bool MatchVeritcal()
        {
            if (CheckVerticallyForX() || CheckVerticallyForO())
                return true;
            return false;
        }
    }
}
