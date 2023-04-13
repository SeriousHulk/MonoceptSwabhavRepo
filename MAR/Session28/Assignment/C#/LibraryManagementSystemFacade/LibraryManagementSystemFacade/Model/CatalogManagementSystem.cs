using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemFacade.Model
{
    internal class CatalogManagementSystem
    {
        public void IssueBook(string username, string title)
        {
            Console.WriteLine($"Issued book {title} to {username}");
        }
    }
}
