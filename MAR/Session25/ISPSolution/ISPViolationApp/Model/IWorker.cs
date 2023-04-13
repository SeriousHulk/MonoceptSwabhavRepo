using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    public interface IWorker
    {
        public void StartWork();
        public void StopWork();
        public void StartEat();
        public void StopEat();
    }
}
