using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulation.Model
{
    internal class Rectangle
    {
        private readonly int _width, _height;
        private string _color;
        public int CalculateArea()
        {
            int area = _width * _height;
            return area;
        }
        public Rectangle(int width, int height, string color)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = ValidateColor(color);
        }
        private int ValidateSide(int side)
        {
            if (side > 100)
                return 100;
            else if (side < 0)
                return 1;
            return side;
        }
        private string ValidateColor(string color)
        {
            if (string.Equals(color, "red", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(color, "blue", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(color, "green", StringComparison.OrdinalIgnoreCase))
            {
                _color = color;
            }
            else
            {
                _color = "red";
            }
            return _color;

        }
        public (int, int) GetSize()
        {
            return (_width, _height);
        }
        public int GetHeight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width;
        }
        public void SetColor(string pColor)
        {
            if (string.Equals(pColor, "red", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(pColor, "blue", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(pColor, "green", StringComparison.OrdinalIgnoreCase))
            {
                _color = pColor;
            }
            else
            {
                _color = "red";
            }
        }
        public string GetColor()
        {
            return _color;
        }
    }
}
