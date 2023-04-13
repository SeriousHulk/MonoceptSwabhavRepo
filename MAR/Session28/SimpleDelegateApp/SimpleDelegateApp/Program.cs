using System.Threading.Channels;

namespace SimpleDelegateApp
{
    delegate void DPrintMessage(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
        }
        private static void CaseStudy1()
        {
            DPrintMessage obj = PrintMessage;
            //obj += PrintHello;
            //obj += PrintGoodbye;
            PrintWizard(PrintMessage);
            //obj("Mahendra");
            //obj("Virat");
        }
        private static void CaseStudy3()
        {
            DPrintMessage fptr;
            fptr = (n) => Console.WriteLine($"Lambda {n}");
            fptr(" V");
        }
        private static void CaseStudy2()
        {
            PrintWizard(PrintHello);
            PrintWizard(PrintGoodbye);
            PrintWizard(delegate (string name)
            {
                Console.WriteLine("Anonymas Delegate Function 1");
                Console.WriteLine(name.ToLower());
            });
            PrintWizard((name) =>
            {
                Console.WriteLine("Lamda function.");
                Console.WriteLine(name.ToLower());
            });
        }

        static void PrintWizard(DPrintMessage fptr)
        {
            Console.WriteLine($"This is messege from within PrintWizard");
            fptr("Champ");
            Console.WriteLine(" \n");
        }
        static void PrintMessage(string name)
        {
            Console.WriteLine($"This is messege for:{name}");
        }
        static void PrintHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        static void PrintGoodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}");
        }
        static void PrintVoid()
        {
            Console.WriteLine("This is messege from within");
        }
    }
}