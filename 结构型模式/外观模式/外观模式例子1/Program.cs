using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 外观模式例子1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Facade
            Mortgage mortgage = new Mortgage();
            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligable = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name +
            " has been " + (eligable ? "Approved" : "Rejected"));
            // Wait for user
            Console.Read();
        }
    }
}
