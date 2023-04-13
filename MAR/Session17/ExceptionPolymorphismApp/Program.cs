using ExceptionPolymorphismApp.Model;

namespace ExceptionPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1234,567,"Mukesh");
            try
            {
                account1.Withdraw(70);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }
    }
}