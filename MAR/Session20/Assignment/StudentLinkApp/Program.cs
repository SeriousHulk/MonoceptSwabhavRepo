using StudentLinkApp.Model;

namespace StudentLinkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student vikrant = new Student { Name="Vikrant" };
            Student anekant = new Student { Name = "Anekant" };
            Student gautam = new Student { Name = "Gautam" };
            Student aishwarya = new Student { Name = "Aishwarya" };

            Student manjunath = new Student { Name = "Manjunath" };
            vikrant.Buddy = aishwarya;
            aishwarya.Buddy = gautam;
            gautam.Buddy = anekant;
            manjunath.Buddy = vikrant;

            vikrant.PrintBuddies(manjunath);
        }
    }
}