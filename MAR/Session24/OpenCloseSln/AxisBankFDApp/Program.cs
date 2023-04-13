using AxisBankFDApp.Policy;
using OCPViolationApp.Model;
using System;

namespace AxisBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit customer = new FixedDeposit(2319, "Ajay", 1200, 1, 
                new DiwaliPolicy());
            customer.CalculateSimpleInteresrt(customer);
            FixedDeposit customer2 = new FixedDeposit(2319, "Akshay", 2200, 10, 
                new NewYearRatePolicy());
            customer2.CalculateSimpleInteresrt(customer2);
        }
    }
}