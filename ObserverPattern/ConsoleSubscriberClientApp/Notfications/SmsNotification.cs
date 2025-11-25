using AccountPublisherLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSubscriberClientApp.Notfications
{
    class SmsNotification : IAccountNotfication
    {
        public void Notify(Account acc)
        {

            Console.WriteLine("SMS is sending to mobile");
            Console.WriteLine(acc.Name);
            Console.WriteLine("your balance state changed " + acc.Balance);
        }
    }
}
