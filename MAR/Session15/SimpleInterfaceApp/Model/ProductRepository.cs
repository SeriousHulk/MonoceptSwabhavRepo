using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class ProductRepository:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Product Record created");
        }
        public void Read()
        {
            Console.WriteLine("Product Record Selected");
        }
        public void Update()
        {
            Console.WriteLine("Product Record Updated");
        }
        public void Delete()
        {
            Console.WriteLine("Product Record Deleted");
        }
    }
}
