using DIPRefactoredApp.HighLevelModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPRefactoredApp.LowLevelModules
{
    class DbLogger : ILogger
    {
        public void Log(Exception ex)
        {
            Console.WriteLine("connecting to db"+ex.Message);
        }
    }
}
