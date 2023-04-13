using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPBirdsSolutionApp.Model
{
    abstract class Bird
    {
        protected string _name;

        protected Bird(string name)
        {
            _name = name;
        }
        public virtual void SetName(string name) {
            _name = name;
        }
        public abstract void Fly(Bird bird);

        internal object GetName()
        {
            return _name;
        }
    }
}
