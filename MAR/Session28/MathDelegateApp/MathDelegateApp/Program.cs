namespace MathDelegateApp
{
    delegate void DMathOperations(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator(Addition);
            Calculator(Subtraction);
            Calculator(Product);
            Calculator(Modules);
        }
        static void Calculator(DMathOperations ptr)
        {
            ptr(20,10);
        }
        private static void Product(int x, int y)
        {
            Console.WriteLine($"The Product of {x} and {y} is {x * y}");
        }
        static void Addition(int x, int y)
        {
            Console.WriteLine($"The Addition of {x} and {y} is {x+y}");
        }
        static void Subtraction(int x, int y)
        {
            Console.WriteLine($"The Subtraction of {x} and {y} is {x - y}");
        }
        private static void Modules(int x, int y)
        {
            Console.WriteLine($"The Modulus of {x} and {y} is {x % y}");
        }
    }
}