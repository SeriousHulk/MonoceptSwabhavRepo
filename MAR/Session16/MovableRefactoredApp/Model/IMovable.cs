using MovableInterfaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableRefactoredApp.Model
{
    internal interface IMovable
    {
        void Move();
        string Name { get; set; }
    }
}
