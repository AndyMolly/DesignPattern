using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式例子1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers cus = new Customers("China");
            cus.Data = new CustomersData();
            cus.ShowAll();
            Console.ReadKey();
        }
    }
}
