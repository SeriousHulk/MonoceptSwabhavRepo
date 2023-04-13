
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPRefactoredWithDelegateApp.HighLevel
{
    internal delegate void DLogger(Exception ex);
    internal class TaxCalculator
    {
        private DLogger _errorLogger;
        public TaxCalculator(DLogger errorLogger)
        {
            _errorLogger = errorLogger;
        }
        public int CalculateTax(int income, int rate)
        {
            int result = -1;
            try
            {
                result = income / rate;
            }
            catch (Exception ex)
            {
                _errorLogger(ex);
            }
            return result;
        }
    }
}
