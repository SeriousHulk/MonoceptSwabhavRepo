namespace OddEven.Model
{
    internal class Even
    {
        private readonly int[] _even;
        public Even(int number)
        {
            int totalEvens = (number) / 2 + 1;
            _even = new int[totalEvens];
            int count = 0;
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    _even[count++] = i;
                }
            }
        }
        public Even(int firstElement, int lastElement)
        {
            int totalEvens = (lastElement - firstElement) / 2 + 1;
            _even = new int[totalEvens];
            int count = 0;
            for (int i = firstElement; i <= lastElement; i++)
            {
                if (i % 2 == 0)
                {
                    _even[count++] = i;
                }
            }
        }
        public int[] GetEven
        {
            get { return _even; }
        }
    }
}
