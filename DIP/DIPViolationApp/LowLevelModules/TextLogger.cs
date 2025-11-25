using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LowLevelModules
{
    class TextLogger
    {

        public void Log(Exception ex) //iSA
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Logging to Text file...");
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }
    }
}
