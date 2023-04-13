using DIPViolationApp.LowLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.HighLevel
{
    internal class TaxCalculator
    {
        private ErrorLogOptions _errorLogOptions;

        public TaxCalculator(ErrorLogOptions errorOptions)
        {
            _errorLogOptions = errorOptions;
        }
        public int CalulateTax(int income,int rate)
        {
            int result = -1;

            try
            {
                result = income / rate;
            }
            catch(Exception ex) { 
                if(_errorLogOptions == ErrorLogOptions.TXT)
                {
                    var textLogger = new TextErrorLogger();
                    textLogger.Log(ex);
                }
                else if(_errorLogOptions == ErrorLogOptions.XML)
                {
                    var xmlLogger = new XMLErrorLogger();
                    xmlLogger.Log(ex);
                }
            }
            return result; 
        }
    }
}
