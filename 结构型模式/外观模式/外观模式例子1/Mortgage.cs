using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*抵押贷款*/
namespace 外观模式例子1
{
    class Mortgage
    {
        Bank bank;
        Credit credit;
        Loan loan;
        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
                          cust.Name, amount);
            bool eligible = true;
            // Check creditworthyness of applicant
            if (!bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(cust))
            {
                eligible = false;
            }
            return eligible;
        }
    }
    class Bank
    { 
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
    class Customer
    {
        private string name;
        public string Name { get { return name; } }
        public Customer(string name)
        {
            this.name = name;
        }
    }
}
