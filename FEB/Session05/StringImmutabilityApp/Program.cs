using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringImmutabilityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
        }
        private static void CaseStudy1()
        {
            String userName = "Vikrant";
            Console.WriteLine($"CaseStudy1 : {userName}\n");
            userName = userName.ToUpper();
            Console.WriteLine($"CaseStudy1 : {userName}\n");
        }
        private static void CaseStudy2()
        {
            String userName = "Vikrant ";
            Console.WriteLine($"CaseStudy2 : {userName}\n");
            Console.WriteLine("cs2 hashCode ->{0}\n", userName.GetHashCode());
            userName += " Develpoer";
            Console.WriteLine($"CaseStudy2 : {userName}\n");
            Console.WriteLine("cs2 hashCode ->{0}\n", userName.GetHashCode());
            Console.WriteLine($"CaseStudy2 : {userName}\n");
        }
        private static void CaseStudy3()
        {
            StringBuilder userName = new StringBuilder();
            userName.Append(" @Monocept");
            Console.WriteLine($"CaseStudy3 : {userName}\n");
            Console.WriteLine("cs3 hashCode ->{0}", userName.GetHashCode());
            userName.Append(" Developer");
            Console.WriteLine("cs3 hashCode ->{0}", userName.GetHashCode());
            userName.Append(" from Hyderabad");
            Console.WriteLine("cs3 hashCode ->{0}", userName.GetHashCode());
        }
    }
}
