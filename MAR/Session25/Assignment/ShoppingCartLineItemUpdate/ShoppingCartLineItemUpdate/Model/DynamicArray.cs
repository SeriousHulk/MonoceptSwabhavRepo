namespace ShoppingCartDynamicArray.Model
{
    internal class DynamicArray<DArray>
    {
        private int _size;
        private DArray[] _array; 
        private int _capacity;
        public DynamicArray()
        {
            _capacity = 5;
            _size = 0;
            _array = new DArray[_capacity];
        }
        public void Add(DArray array)
        {
            
            CheckIfArrayFull();
            _array[_size++] = array;
            _capacity++;
        }
        public void CheckIfArrayFull()
        {
            int _newCapacity;
            DArray[] newArr = new DArray[_capacity];
            if (_size == _capacity) 
            {
                _newCapacity = _size * 2; 
                for(int i = 0; i<_array.Length; i++)
                {
                    newArr[i] = _array[i];
                }
                _array = newArr;
            }
        }
        public IEnumerator<DArray> GetEnumerator()
        {
            for (int i = 0; i < _size; i++)
            {
                yield return _array[i];
            }
        }
    }
}
