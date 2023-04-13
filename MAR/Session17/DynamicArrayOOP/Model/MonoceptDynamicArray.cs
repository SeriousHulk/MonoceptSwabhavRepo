using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayOOP.Model
{
    internal class MonoceptDynamicArray
    {
        int count;
        private int[] _monoceptArray;
        public MonoceptDynamicArray(int size)
        {
            this.count = 0;
            _monoceptArray = new int[size];
        }
        public int[] Numbers { get { return _monoceptArray; } }
        public void Add(int number)
        {
            CheckIfArrayFull();
            _monoceptArray[count] = number;
            count++;
        }
        private void CheckIfArrayFull()
        {
            if (count == _monoceptArray.Length)
            {
                int[] newArr = new int[_monoceptArray.Length * 2];
                for (int i = 0; i < Numbers.Length; i++)
                {
                    newArr[i] = _monoceptArray[i];
                }
                _monoceptArray = newArr;
            }
        }
    }
}