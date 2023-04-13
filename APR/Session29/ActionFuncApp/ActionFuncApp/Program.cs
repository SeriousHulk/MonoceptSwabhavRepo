using System.Xml.Linq;

namespace ActionFuncApp
{
    //delegate bool Dpredicate(int no);
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
        }
        private static void CaseStudy1()
        {
            Predicate<int> predicate = (no) =>
            {
                return no % 2 == 0;
            };
            //Dpredicate predicate = CheckIsEven;
            Console.WriteLine(predicate(30));
        }
        private static void CaseStudy2()
        {
            Predicate<string> predicate = (name) =>
            {
                return name.Length > 7;
            };
            Console.WriteLine(predicate("Rajinikanth"));
        }
        private static void CaseStudy3()
        {
            Func<string, bool> longNameCheck = (name) =>
            {
                return name.Length > 7;
            };
            Console.WriteLine(longNameCheck(new string("Sudhakaran")));
        }
        private static void CaseStudy4()
        {
            Action<int, int> action = (a, b) =>
            {
                Console.WriteLine($"{a}+{b}={a + b}");
            };
            action(23, 37);
        }
    }
}