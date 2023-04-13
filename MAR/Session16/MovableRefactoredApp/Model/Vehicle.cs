using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableRefactoredApp.Model
{
     abstract class Vehicle: IMovable
    {
        private string _name;
        public Vehicle(string name)
        {
            _name = name;
        }
        public string Name{ get { return _name; } }

        string IMovable.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract void Move();
    }
}
