namespace ExceptionPropogationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Main");
            try { F1(); }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message.ToUpper()); 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
            }
            Console.WriteLine("End of Main");
        }

        private static void F1()
        {
            Console.WriteLine("Inside F1");
            F2();
            Console.WriteLine("End of F1");
        }

        private static void F2()
        {
            Console.WriteLine("Inside F2");
            F3();
            Console.WriteLine("End of F2");
        }

        private static void F3()
        {
            Console.WriteLine("Inside F3");
            throw new Exception("something wrong in F3");
        }
    }
}