using System.Reflection.Metadata;

namespace CostomAttributePOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var attributes = Attribute.GetCustomAttributes(typeof(UserClass));
            foreach (var attribute in attributes)
            {
                if (attribute is CustomAttributeClass myCustomAttribute)
                {
                    Console.WriteLine($"Class name: {myCustomAttribute.Name}, ID: {myCustomAttribute.Id}");
                }
            }
        }
        public class CustomAttributeClass : Attribute
        {
            public CustomAttributeClass(string name, int id)
            {
                Name = name;
                Id = id;
            }

            public string Name { get; }
            public int Id { get; }
        }
        [CustomAttributeClass("userClass",101)]
        class UserClass
        {
            public UserClass()
            {
            }
        }
    }
}