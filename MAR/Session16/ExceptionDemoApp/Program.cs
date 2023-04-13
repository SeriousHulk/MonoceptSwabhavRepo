namespace ExceptionDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(args[0]);
            int second = int.Parse(args[1]);
            int result = first/second;
            Console.WriteLine($"{first}/{second}={result}");
            Console.WriteLine("End of main");
            Main(args);
        }
    }
}
/*
    System.IndexOutOfRangeException line no.7  args[0]= ,args[1]= ;
    System.DivideByZeroException    line no.9  args[0]=1,args[1]=0;
    System.FormatException          line no.8  args[0]=4,args[1]=n; 
*/