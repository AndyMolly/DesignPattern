using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式例子1
{
   abstract class Approver
    {
       protected Approver successor;
       public void SetSuccessor(Approver successor)
       {
           this.successor = successor;
       }
       public abstract void ProcessRequest(Purchase purchase);
    }
   class Director : Approver
   {

       public override void ProcessRequest(Purchase purchase)
       {
           if (purchase.Amount < 10000.0)
           {
               Console.WriteLine("{0} approved request# {1}",
               this.GetType().Name, purchase.Number);
           }
           else if (successor != null)
           {
               successor.ProcessRequest(purchase);
           }
       }
   }
   class VicePresident : Approver
   {
       public override void ProcessRequest(Purchase purchase)
       {
           if (purchase.Amount < 25000.0)
           {
               Console.WriteLine("{0} approved request# {1}",
               this.GetType().Name, purchase.Number);
           }
           else if (successor != null)
           {
               successor.ProcessRequest(purchase);
           }
       }
   }
   class President : Approver
   {

       public override void ProcessRequest(Purchase purchase)
       {
           if (purchase.Amount < 100000.0)
           {
               Console.WriteLine("{0} approved request# {1}",
               this.GetType().Name, purchase.Number);
           }
           else
           {
               Console.WriteLine("Request # {0} requires an executing meeting",purchase.Number);
           }
       }
   }

    class Purchase
    {
        private int number;
        private double amount;
        private string purpose;
        // Constructor
        public Purchase(int number, double amount, string purpose)
        {
            this.number = number;
            this.amount = amount;
            this.purpose = purpose;
        }
        // Properties
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
