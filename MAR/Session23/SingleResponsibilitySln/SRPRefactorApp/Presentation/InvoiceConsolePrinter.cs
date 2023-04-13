using SRPRefactorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactorApp.Presentation
{
    internal class InvoiceConsolePrinter
    {
        public void PrintInvoice(Invoice invoice)
        {
            string template = $"ID is {invoice.Id}, description is {invoice.Description}" +
                $" cost is {invoice.Cost} " +
                $"Tax is {invoice.CalculateTax()} " +
                $"and Discount is {invoice.CalculateDiscount()} " +
                $"Final Cost {invoice.CalculateFinalCost()}";
            Console.WriteLine(template);
        }
    }
}
