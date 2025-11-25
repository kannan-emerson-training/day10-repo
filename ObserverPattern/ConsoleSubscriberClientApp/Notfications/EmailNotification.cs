using AccountPublisherLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSubscriberClientApp.Notfications
{
    class EmailNotification : IAccountNotfication
    {
        public void Notify(Account acc)
        {

            Console.WriteLine("email is sending to");
            Console.WriteLine(acc.Name);
            Console.WriteLine("your state change "+acc.Balance);
        }
    }
}
