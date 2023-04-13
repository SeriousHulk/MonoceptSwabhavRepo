using CustomerHashSetApp.Model;
using System;
using System.Collections.Generic;

namespace CustomerHashSetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }
        private static void CaseStudy1()
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("Anekant");
            names.Add("Ravi");
            names.Add("Vikrant");
            names.Add("vikrant");
            names.Add("Ekta");
            Console.WriteLine("\nCaseStudy1");
            Console.WriteLine(names.Count);
            foreach (string name in names)
            {
                Console.WriteLine("Name " + name + " and HashCode :" + name.GetHashCode());
            }
        }
        private static void CaseStudy2()
        {
            HashSet<int> scores = new HashSet<int>();
            scores.Add(1);
            scores.Add(3);
            scores.Add(23);
            scores.Add(3);
            scores.Add(23);
            Console.WriteLine("\nCaseStudy2");
            foreach (int i in scores)
            {
                Console.WriteLine("Hash code of number  (" + i + "):" + i.GetHashCode());
            }
            Console.WriteLine(scores.Count);
        }
        private static void CaseStudy3()
        {
            Customer c1 = new Customer(15463, "Vikrant");
            Customer c2 = new Customer(14567, "Vikrant");
            Customer c3 = new Customer(15463, "Anekant");
            HashSet<Customer> customers = new HashSet<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            Console.WriteLine("\nCaseStudy3");
            Console.WriteLine("Hash code of first customer :" + c1.GetHashCode());
            Console.WriteLine("Hash code of second customer :" + c2.GetHashCode());
            Console.WriteLine("Hash code of third customer :" + c3.GetHashCode());
            Console.WriteLine("Total customer count :" + customers.Count);
        }
    }
}