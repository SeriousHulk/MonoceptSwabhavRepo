using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemFacade.Model
{
    internal class BookManagementSystem
    {
        public void AddBook(string title, string author)
        {
            Console.WriteLine($"Added book {title} by {author}");
        }
    }
}
