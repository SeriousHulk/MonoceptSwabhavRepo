using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp.Model
{
    internal class Rectangle
    {
        private int _width, _height;
        private ColorOption _color;
        private BorderOption _border;
        public Rectangle(int width, int height, ColorOption color)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = color;
            _border = BorderOption.SINGLE;
        }
        public Rectangle(int width, int height, ColorOption color, BorderOption border)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = color;
            _border = border;
        }

        public Rectangle()
        {
        }

        public int CalculateArea()
        {
            
            int area = _width * _height;
            return area;
        }
        public int Width { get { return ValidateSide(_width); } set { _width = value; } }
        public int Height { get { return ValidateSide(_height); } set { _height = value; } }
        public ColorOption Color { get { return _color; } set { _color = value; } }
        public BorderOption Border { get { return _border; } set { _border = value; } }
        private int ValidateSide(int side) { if (side < 1) { side = 1; }
            else if (side > 100)
            {
                side = 100;
            }
            return side; ;
        }
    }
}
