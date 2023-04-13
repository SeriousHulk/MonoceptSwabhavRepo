using ManBoyInheritance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            //CaseStudy4();
            CaseStudy5();
        }
        private static void CaseStudy1()
        {
            Console.WriteLine("**************Case Study 1*************");
            Boy boy = new Boy();
            boy.Play();
            boy.Eat();
            boy.Read();
        }
        private static void CaseStudy2()
        {
            Console.WriteLine("**************Case Study 2*************");
            Man man = new Man();
            man.Play();
            man.Read();
        }
        private static void CaseStudy3()
        {
            Console.WriteLine("**************Case Study 3*************");
            Man boy = new Boy();
            boy.Play();
        }
        private static void CaseStudy4()
        {
            Console.WriteLine("**************Case Study 4*************");
            AtThePark(new Man());
            AtThePark(new Kid());
            AtThePark(new Boy());
            AtThePark(new Infant());
        }
        private static void AtThePark(Man man)
        {
            Console.WriteLine("At the Park");
            man.Play();
        }
        private static void CaseStudy5()
        {
            Console.WriteLine("**************Case Study 5*************");
            Object box;
            box = 10;
            Console.WriteLine($"box is {box} of type {box.GetType()}");
            box = "String";
            Console.WriteLine($"box is {box} of type {box.GetType()}");
            box = new Man();
            //Man manbox = (Man)box;
            //manbox.Play();
            Console.WriteLine($"box is {box} of type {box.GetType()}");
            Man man = new Man();
            Console.WriteLine($"man is {man} of type {man.GetType()}\n");
            man.Read();
        }
    }
}
