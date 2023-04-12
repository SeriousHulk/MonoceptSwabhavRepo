using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVsClass.Model
{
    public struct PointStruct
    {
        private int x1;
        private int y1;
        public PointStruct(int x1, int y1)
        { this.x1 = x1; this.y1 = y1; }
        public int GetX
        { get { return x1; } set { x1 = value; } }
        public int GetY
        { get { return y1; } set { y1 = value; } }
        public void ShowStruct()
        {
            Console.WriteLine($"{x1} {y1}");
        }
    }
}
