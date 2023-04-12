using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp.Model
{
    internal class Dry
    {
        // without DRY
        int perimter = 2 * (3 + 4);

        // with DRY
        public int length;
        public int width;
        public Dry(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public int CalculatePerimeter()
        {
            int area2 = 2 * (length + width);
            return area2;
        }
    }
}
        
    

