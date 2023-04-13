using LSPViolationApp.Model;
using System.Xml;

namespace LSPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(34,67);
            Square square = new Square(33);
            ShouldNotChangeHeight_IfWidthChanged(rectangle1);
            ShouldNotChangeHeight_IfWidthChanged(square);
        }

        private static void ShouldNotChangeHeight_IfWidthChanged
            (Rectangle rectangle)
        {
            int beforeChange = rectangle.GetHeight();
            rectangle.SetWidth(55);
            int afterChange = rectangle.GetHeight();
            Console.WriteLine(beforeChange == afterChange);
            Console.WriteLine(beforeChange);
            Console.WriteLine(afterChange+"\n");
        }
    }
}