using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.HighLevel
{
    public interface IErrorLogger
    {
        void Log(Exception exception);
    }
}
