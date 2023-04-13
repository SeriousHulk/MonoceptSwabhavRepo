using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternApp.Model
{
    internal interface IStorageItem
    {
        void Display(int depth = 0);
    }
}
