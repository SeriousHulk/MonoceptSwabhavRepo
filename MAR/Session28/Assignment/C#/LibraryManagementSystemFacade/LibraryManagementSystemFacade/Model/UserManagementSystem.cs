using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemFacade.Model
{
    internal class UserManagementSystem
    {
        public void AddUser(string username, string password)
        {
            Console.WriteLine($"Added user {username} with password {password}");
        }
    }
}
