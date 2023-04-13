using RefactorApp.Model;
using System.Reflection;

namespace RefactorApp
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
            Foo foo1 = new Foo();
            var methodsToRefactor = FindMethodsNeedToRefactor(foo1.GetType());
            Console.WriteLine($"Found {methodsToRefactor.Length} methods to refactor:");
            foreach (var mi in methodsToRefactor)
            {
                Console.WriteLine(mi.Name);
            }
        }
        private static void CaseStudy2()
        {
            Bar foo1 = new Bar();
            var methodsToRefactor = FindMethodsNeedToRefactor(foo1.GetType());
            Console.WriteLine($"Found {methodsToRefactor.Length} methods to refactor:");
            foreach (var mi in methodsToRefactor)
            {
                Console.WriteLine(mi.Name);
            }
        }
        private static MethodInfo[] FindMethodsNeedToRefactor(Type type)
        {
            var methods = type.GetMethods();
            var methodsToRefactor = methods.Where(mi => mi.GetCustomAttribute(typeof(NeedToRefactor)) != null).ToArray();
            return methodsToRefactor;
        }
    }
    class Foo
    {
        public void M1() { }
        [NeedToRefactor]
        public void M2() { }
        [NeedToRefactor]
        public void M3() { }
        public void M4() { }
        public void M5() { }
    }
    class Bar
    {

        public void M1() { }
        public void M2() { }
        [NeedToRefactor]
        public void M3() { }
        public void M4() { }
        [NeedToRefactor]
        public void M5() { }
    }
}