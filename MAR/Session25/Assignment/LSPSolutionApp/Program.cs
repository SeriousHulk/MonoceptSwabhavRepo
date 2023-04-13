using LSPSolutionApp.Model;

namespace LSPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(34, 67);
            Square square = new Square(33);
            ShouldNotChangeHeight_IfWidthChanged(rectangle1);
            ShouldChangeHeight_IfWidthChanged(square);
        }

        private static void ShouldNotChangeHeight_IfWidthChanged
            (Rectangle rectangle)
        {
            int beforeChange = rectangle.GetHeight();
            rectangle.SetWidth(55);
            int afterChange = rectangle.GetHeight();
            Console.WriteLine(beforeChange == afterChange);
            Console.WriteLine(beforeChange);
            Console.WriteLine(afterChange + "\n");
        }
        private static void ShouldChangeHeight_IfWidthChanged
            (Square square)
        {
            int beforeChange = square.GetSide();
            square.SetSide(55);
            int afterChange = square.GetSide();
            Console.WriteLine(beforeChange != afterChange);
            Console.WriteLine(beforeChange);
            Console.WriteLine(afterChange + "\n");
        }
    }
}