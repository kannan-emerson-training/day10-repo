using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionApp.Domain
{
    class EmersonInsufficientFundsException:Exception//ISA
    {
        private Account _account;//has A
        public EmersonInsufficientFundsException(Account acc)
        { 
         _account = acc;
        }

        public override string Message {

            get { 
            
             return $"admin@emerson says: hello mr {this._account.Name} , your dont have suffiends fund for this txn..";
            }
        
        }
    }
}
