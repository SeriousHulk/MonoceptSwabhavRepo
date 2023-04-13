using SingletonPatternAppV1.Model;

namespace SingletonPatternAppV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy1()
        {
            Console.WriteLine("Case Study 1:\n");
            var service1 = new DataService();
            service1.DoProcessing();
            var service2 = new DataService();
            service2.DoProcessing();
            var service3 = new DataService();
            service3.DoProcessing();
            Console.WriteLine($"Service1 Hash Code {service1.GetHashCode()}");
            Console.WriteLine($"Service2 Hash Code {service2.GetHashCode()}");
            Console.WriteLine($"Service3 Hash Code {service3.GetHashCode()}");
        }
        private static void CaseStudy2()
        {
            Console.WriteLine("\nCaseStudy2:\n");
            var service1 = DataService.GetInstance();
            service1.DoProcessing();
            var service2 = DataService.GetInstance();
            service2.DoProcessing();
            var service3 = DataService.GetInstance();
            service3.DoProcessing();
            Console.WriteLine($"Service1 Hash Code {service1.GetHashCode()}");
            Console.WriteLine($"Service2 Hash Code {service2.GetHashCode()}");
            Console.WriteLine($"Service3 Hash Code {service3.GetHashCode()}");
        }
    }
}