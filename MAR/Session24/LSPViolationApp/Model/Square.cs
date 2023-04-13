using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp.Model
{
    internal class Square : Rectangle
    {
        public Square(int side) : base(side, side)
        {
        }
        public override void SetHeight(int height)
        {
            _height = _width = height;
        }
        public override void SetWidth(int width)
        {
            _height = _width = width;
        }
    }
}
