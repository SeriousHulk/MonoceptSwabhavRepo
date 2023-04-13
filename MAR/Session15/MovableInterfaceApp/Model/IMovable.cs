using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterfaceApp.Model
{
    public interface IMovable
    {
        void Move();
        string Name { get; set; }
    }
}
