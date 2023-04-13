using ReflectionPOC.Model;
using System.Reflection;

namespace ReflectionPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(Movie);
            Movie movie = new Movie();
            MemberInfo[] info2 = movie.GetType().GetMethods();
            Movie movie2 = new Movie();
            object[] attributes = info.GetCustomAttributes(true);
            foreach (object attribute in attributes)
            {
                Console.WriteLine(attribute+"\n");
            }
            foreach (MemberInfo mi in info2)
            {
                Console.WriteLine(mi);
            }



            //Movie movie2 = new Movie();
            //Type type = typeof(Movie);
            //PropertyInfo myPropertyInfo = type.GetProperty("property");
            //myPropertyInfo.SetValue(movie, movie2);
            //int myPropertyValue = (int)myPropertyInfo.GetValue(movie);
            //Console.WriteLine("MyProperty value: " + myPropertyValue);
            //MethodInfo myMethodInfo = type.GetMethod("MyMethod");
            //myMethodInfo.Invoke(movie, new object[] { "Hello World!" });
            //Console.WriteLine(myPropertyInfo);
        }
    }
}