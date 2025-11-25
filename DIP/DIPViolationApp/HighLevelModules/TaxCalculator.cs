using DIPViolationApp.LowLevelModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.HighLevelModules
{
    class TaxCalculator
    {

        private LogOptions _logOptions;

        public TaxCalculator(LogOptions logOptions)
        {
            _logOptions = logOptions;
        }

        public int CalculateTax(int income, int rate) {

            int result = -1;


            try
            {

                result = income / rate;
            }
            catch (DivideByZeroException ex) {

                if (_logOptions == LogOptions.Text)
                {

                    TextLogger textLogger = new TextLogger();
                    textLogger.Log(ex);

                }
                else if (_logOptions == LogOptions.Xml) { 
                
                       XmlLogger xmlLogger = new XmlLogger();
                       xmlLogger.Log(ex);
                }

            
            }




            return result;
        
        }
    }
}
