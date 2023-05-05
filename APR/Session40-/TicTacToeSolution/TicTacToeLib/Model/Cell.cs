using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib.Model
{
    public class Cell
    {
        private MarkType _mark;
        public Cell()
        {
            _mark = MarkType.Empty;
        }
        public Cell(MarkType mark)
        {
            _mark = mark;
        }
        public bool IsAlreadyMarked()
        {
            return (Mark != MarkType.Empty);
        }
        public MarkType Mark
        {
            get { return _mark; }
            set
            {
                if (IsAlreadyMarked())
                    throw new CellAlreadyMarkedException("This Cell is Already Marked!!");
                _mark = value;     
            }
        }
    }
}

