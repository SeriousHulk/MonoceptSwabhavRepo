using OCPViolationApp.Model;

namespace OCPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixedDeposit = new FixedDeposit(1001, 
                "Rupesh", 1000000, 1, FestivalOptions.Normal);
            fixedDeposit.CalculateSimpleInteresrt();
        }
    }
}