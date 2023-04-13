namespace AccountUnitTestApp.Model
{
    public class Calculator
    {
        public int CubeOnlyEvenNumbers(int no)
        {
            if (no % 2 == 0)
            {
                return no*no*no;
            }
            return -1;
        }
        public int Add(params int[] numbers)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                result += i;
            }
            return result;
        }
    }
}
