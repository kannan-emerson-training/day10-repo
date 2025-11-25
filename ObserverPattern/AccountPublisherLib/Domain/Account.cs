using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPublisherLib.Domain
{
    public class Account //source,publisher,observable
    {
        private readonly int _accono;
        private readonly string _name;
        private double _balance;
        //list of subscribers,observers
        private List<IAccountNotfication> _observers= new List<IAccountNotfication>();

        private const int MIN_BALANCE = 500;

        public Account(int accno, string name, double balance)
        {
            Console.WriteLine("account created(#1)");
            _accono = accno;
            _name = name;
            _balance = balance;
        }

        public Account(int accno, string name)
        {
            Console.WriteLine("account created(#2)");
            _accono = accno;
            _name = name;
            _balance = MIN_BALANCE;
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
            NotifyAllTheObservers();

            
        }


        public void AddObserver(IAccountNotfication observer) { 
        
            _observers.Add(observer);
        }


        public void Withdraw(double amount)
        {

            if (!SuffientFundsAvailabe(amount))
            {
                throw new NotSupportedException("Not supporeted @emerson");
               // throw new EmersonInsufficientFundsException(this);
            }
             
            _balance = _balance-amount;
            NotifyAllTheObservers();

        }

        private void NotifyAllTheObservers()
        {
            foreach (IAccountNotfication observer in _observers)
            {
                observer.Notify(this);
            }
        }

        private bool SuffientFundsAvailabe(double amount)
        {
            if (_balance - amount >= MIN_BALANCE) {
                return true;
            }
            return false;
        }


        public int AccountNo
        {
            get
            {
                return _accono;
            }
        }
        public string Name
        {
            get { return _name; }
        }
        public double Balance
        {
            get { return _balance; }
        }


    }
}
