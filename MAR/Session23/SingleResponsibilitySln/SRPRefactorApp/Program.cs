using SRPRefactorApp.Model;
using SRPRefactorApp.Presentation;

namespace SRPRefactorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(01, "Invoice 1", .50, 100);
            InvoiceHTMLPrinter invoiceHTMLPrinter = new InvoiceHTMLPrinter();
            invoiceHTMLPrinter.PrintToHTML(invoice);

        }
    }
}