using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LowLevelModules
{
    class XmlLogger
    {
        public void Log(Exception ex) //iSA
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Logging to XML file...");
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }
    }
}
