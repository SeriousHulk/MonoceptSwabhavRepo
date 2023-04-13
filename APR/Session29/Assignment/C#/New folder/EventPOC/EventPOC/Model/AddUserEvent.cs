using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPOC.Model
{
    public class AddUserEvent
    {
        public event Action AddUser;
        public void TriggerEvent()
        {
            Console.WriteLine("Event triggered.");
            AddUser?.Invoke();
        }
    }
}
