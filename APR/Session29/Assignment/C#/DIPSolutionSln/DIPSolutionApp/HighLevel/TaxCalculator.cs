using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.HighLevel
{
    internal class TaxCalculator
    {
        private IErrorLogger _errorLogger;
        private DLogger xmlLogger;

        public TaxCalculator(IErrorLogger errorOptions)
        {
            _errorLogger = errorOptions;
        }

        public TaxCalculator(DLogger xmlLogger)
        {
            this.xmlLogger = xmlLogger;
        }

        public Exception CalculateTax(int income,int rate)
        {
            int result = -1;
            try
            {
                result = income / rate;
            }
            catch (Exception ex)
            {
                _errorLogger.Log(ex);
            }
            return result; 
        }
    }
}
