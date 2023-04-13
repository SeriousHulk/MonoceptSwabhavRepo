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
                account1.Withdraw(57);
                Console.WriteLine($"Account balance after withdraw : {account1.Balance}");
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