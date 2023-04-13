using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventApp.Model
{
    public interface IAccountNotifier
    {
        void Notify(Account account);
    }
}
