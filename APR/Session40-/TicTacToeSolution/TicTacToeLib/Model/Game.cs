using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib.Model
{
    public class Game
    {
        private Board _board;
        private ResultAnalyser _resultAnalyser;
        private Player[] _players;
        private Player _currentPlayer;
        private ResultType _status;

        public Game(Board board, ResultAnalyser resultAnalyser, Player[] players)
        {
            _board = board;
            _resultAnalyser = resultAnalyser;
            _players = players;
            _currentPlayer = players[0];
            _status = ResultType.No_Result;
        }

        public void Play(int cellPosition)
        {
            _board.MarkCell(cellPosition, _currentPlayer.MarkType);
            _status = _resultAnalyser.Analyze();
            if (_currentPlayer == _players[0])
            {
                _currentPlayer = _players[1];
            }
            else
            {
                _currentPlayer = _players[0];
            }
        }
        public ResultType Status
        {
            get
            {
                return _status;
            }
        }

        public Player CurrentPlayer
        {
            get
            {
                return _currentPlayer;
            }
        }
        public Board Board
        {
            get
            {
                return _board;
            }
        }
    }
}
