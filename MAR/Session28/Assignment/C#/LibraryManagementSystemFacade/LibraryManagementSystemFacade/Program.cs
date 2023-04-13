using LibraryManagementSystemFacade.Model;
namespace LibraryManagementSystemFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var facade = new LibraryManagementSystem();
            facade.AddUserAndBook("Vikrant", "pass123", "Prisnor of Azkaban", "J.K.Row");
            facade.IssueBook("J.K.Row", "Prisnor of Azkaban");
        }
    }
}