using DynamicArrayOOP.Model;
namespace DynamicArrayOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new MonoceptDynamicArray(5);
            ArrayIO(array);
        }
        private static void ArrayIO(MonoceptDynamicArray array)
        {
            while (true)
            {
                Console.WriteLine("\nEnter a number :");
                int input = int.Parse(Console.ReadLine());
                array.Add(input);
                foreach (int value in array.Numbers)
                {
                    Console.Write(value + " ");
                }
            }
        }
    }
}