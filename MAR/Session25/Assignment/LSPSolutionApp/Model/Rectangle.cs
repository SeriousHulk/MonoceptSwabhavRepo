using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp.Model
{
    internal class Rectangle:Polygon
    {
        protected int _width;
        protected int _height;
        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }
        public virtual void SetWidth(int width)
        {
            _width = width;
        }
        public int GetWidth() {  return _width; }
        public virtual void SetHeight(int height)
        {
            _height = height;
        }
        public int GetHeight() { return _height; }
        public override double CalculateArea()
        {
            return _height * _width;
        }
    }
}
