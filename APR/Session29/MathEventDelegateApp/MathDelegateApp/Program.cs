using MathDelegateApp.Model;

namespace MathDelegateApp
{
    delegate void DMathOperations(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator operation1 = new Calculator();
            operation1.SubtractionCompleted += PrintResult;
            operation1.Addition(23,43);

        }
        private static void PrintResult(int x, int y)
        {
            Console.WriteLine(" ");
        }
    }
}