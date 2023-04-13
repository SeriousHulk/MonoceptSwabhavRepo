using AxisBankFDApp.Policy;
using OCPViolationApp.Model;
using System;
namespace KotakBankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit customer = new FixedDeposit(12319, "Ajay", 8524, 6, 
                new Quater1Policy());
            customer.CalculateSimpleInteresrt(customer);
            FixedDeposit customer2 = new FixedDeposit(12319, "Akshay", 6541, 4,
                new Quater2Policy());
            customer2.CalculateSimpleInteresrt(customer2);
        }
    }
}