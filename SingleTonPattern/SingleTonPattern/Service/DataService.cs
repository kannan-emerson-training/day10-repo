using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern.Service
{
    class DataService
    {
        private  static  DataService _bucket=null;

        private DataService() {
             Console.WriteLine("Data Service created"); 
        }

        public static  DataService CreateAnInstance() {

            if (_bucket == null) { 
              _bucket = new DataService();
            }

            return _bucket;
        }


        public string GetData() {

            

            Random random = new Random();
           int data= random.Next(100);
            return "Getting data from outside :" + data + " work done by : "+this.GetHashCode();
        }
    }
}
