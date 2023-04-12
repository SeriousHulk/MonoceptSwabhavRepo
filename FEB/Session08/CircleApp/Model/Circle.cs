using System;

namespace CircleApp.Model
{
    internal class Circle
    {
        private int _radius;
        private readonly string _color;
        private string _borderStyle;
        public Circle(int radius, string color, string borderStyle) {
            _radius = ValidateRadius(radius);
            _color = ValidateColor(color); 
            _borderStyle = ValidateBorder(borderStyle); 
        }
        public int Radius
        {
            get { return _radius; }
            set { _radius = ValidateRadius(value); }
        }
        public string Color
        {
            get { return _color; }
        }
        public string BorderStyle 
        {
            get { return _borderStyle; }
            set { _borderStyle = ValidateBorder(value); }
        }
        public int ValidateRadius(int radius)
        {
            if (radius > 10)
            {
                return 10;
            }
            else if (radius < 0)
            {
                return 1;
            }
            else return radius;
        }
        public string ValidateColor(string color)
        {
            if (string.Equals(color, "red", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(color, "blue", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(color, "green", StringComparison.OrdinalIgnoreCase))
            {
                return color;
            }
            else { return  "Blue"; }
        }
        public string ValidateBorder(string borderStyle)
        {
            if (string.Equals(borderStyle, "single", StringComparison.OrdinalIgnoreCase) ||
             string.Equals(borderStyle, "dotted", StringComparison.OrdinalIgnoreCase) ||
             string.Equals(borderStyle, "double", StringComparison.OrdinalIgnoreCase))
            {
                return borderStyle;
            }
            else { return "Single"; }
        }
    }
}
