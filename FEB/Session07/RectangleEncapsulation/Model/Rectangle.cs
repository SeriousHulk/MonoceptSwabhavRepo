using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulation.Model
{
    internal class Rectangle
    {
        private int _width, _height;
        private string _color;
        public int CalculateArea()
        {
            int area = _width * _height;
            return area;
        }
        public void SetHeight(int height)
        {
            _height = SetSize(height);
        }
        public void SetWidth(int width)
        {
            _width = SetSize(width);
        }
        private int SetSize(int side)
        {
            if (side < 0)
            {
                side = 1;
            }
            else if (side > 100)
            {
                side = 100;
            }
                  return side; ;
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
