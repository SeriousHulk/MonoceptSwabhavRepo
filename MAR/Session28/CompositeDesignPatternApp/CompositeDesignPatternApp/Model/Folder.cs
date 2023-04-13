using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternApp.Model
{
    internal class Folder : IStorageItem
    {
        private string _name;
        private List<IStorageItem> _children;
        public Folder(string name)
        {
            _children = new List<IStorageItem>();
            _name = name;
        }
        public void AddChild(IStorageItem item)
        {
            _children.Add(item);
        }
        public void Display(int depth = 0)
        {
            for(int i = 0; i< depth; i++)
            {
                Console.Write("  ");
            }
            Console.WriteLine($"{_name}");
            foreach (IStorageItem item in _children)
            {
                int dep = depth;
                item.Display(++dep);
            }
        }
    }
}
