using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp.Model
{
    internal class Circle
    {
        private int _radius;
        private string _color, _borderStyle;
        public void SetRadius(int radius)
        {
            if (_radius > 10)
            {
                _radius = 10;
            }
            else if (_radius < 0)
            {
                _radius = 1;
            }
            else _radius = radius;
        }
        public int GetRadius()
        {
            return _radius;
        }
        public void SetParams(string color, string borderStyle)
        {
            if (string.Equals(color, "red", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(color, "blue", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(color, "green", StringComparison.OrdinalIgnoreCase))
            {
                _color = color;
            }
            else { _color = "Blue"; }
            if (string.Equals(borderStyle, "single", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(borderStyle, "dotted", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(borderStyle, "double", StringComparison.OrdinalIgnoreCase))
            {
                _borderStyle = borderStyle;
            }
            else { _borderStyle = "Single"; }
        }
        public (string, string) GetParams()
        {
            return (_color,_borderStyle);
        }
    }
}
