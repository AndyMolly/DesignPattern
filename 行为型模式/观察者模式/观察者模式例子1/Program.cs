using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式例子1
{
    class Program
    {
        static void Main(string[] args)
        {

            IBM ibm = new IBM("IBM", 120.0);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Change price, which notifies investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            // Wait for user
            Console.Read();
        }
    }
}
