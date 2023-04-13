using SRPRefactorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactorApp.Presentation
{
    internal class InvoiceHTMLPrinter
    {
        public void PrintToHTML(Invoice invoice)
        {
            string template = $"ID is {invoice.Id}, description is {invoice.Description}" +
                $" cost is {invoice.Cost} " +
                $"Tax is {invoice.CalculateTax()} " +
                $"and Discount is {invoice.CalculateDiscount()} " +
                $"Final Cost {invoice.CalculateFinalCost()}";
            StreamWriter writer = new StreamWriter(invoice.Description + ".html");
            writer.WriteLine("<html><body><h1>");
            writer.WriteLine("<br>");
            writer.WriteLine("ID is :"+ invoice.Id);
            writer.WriteLine("<br>");
            writer.WriteLine("description is :"+invoice.Description);
            writer.WriteLine("<br>");
            writer.WriteLine("cost is :"+invoice.Cost );
            writer.WriteLine("<br>");
            writer.WriteLine("Tax is :"+invoice.CalculateTax());
            writer.WriteLine("<br>");
            writer.WriteLine("and Discount is :" + invoice.CalculateDiscount());
            writer.WriteLine("<br>");
            writer.WriteLine("Final Cost :"+invoice.CalculateFinalCost());
            writer.WriteLine("</h1></body></html>");
            writer.Close();
        }
    }
}
