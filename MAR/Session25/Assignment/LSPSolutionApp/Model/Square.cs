using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp.Model
{
    internal class Square:Polygon
    {
        int _side;
        public Square(int side)
        {
            _side = side;
        }
        public void SetSide(int side)
        {
            _side = side;
        }
        public int GetSide() { return _side; }
        public override double CalculateArea()
        {
            return _side*_side;
        }
    }
}
