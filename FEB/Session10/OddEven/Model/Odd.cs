using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven.Model
{
    internal class Odd
    {
        private readonly int[] _odd;
        public Odd(int number)
        {
            int totalOdds = (number) / 2 + 1;
            _odd = new int[totalOdds];
            int count = 0;
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    _odd[count++] = i + 1;
                }
            }
        }
        public Odd(int firstElement, int lastElement)
        {
            int totalOdds = (lastElement - firstElement) / 2 + 1;
            _odd = new int[totalOdds];
            int count = 0;
            for (int i = firstElement; i <= lastElement; i++)
            {
                if (i % 2 == 0)
                {
                    _odd[count++] = i + 1;
                }
            }
        }
        public int[] GetOdd
        {
            get { return _odd; }
        }
    }
}
