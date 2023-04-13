using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.HighLevel
{
    public delegate void DLogger(Exception ex);
    public interface IErrorLogger
    {
        void Log(Exception ex);
    }
}
