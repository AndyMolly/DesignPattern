using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式例子1
{

    abstract class Stock
    {
        protected string symbol;
        protected double price;
        private ArrayList investors = new ArrayList();
       public Stock(string symbol, double price)
       {
           this.symbol = symbol;
           this.price = price;
       }
       public void Attach(Investor investor)
       {
           investors.Add(investor);
       }
       public void Detach(Investor inverstor)
       {
           investors.Remove(inverstor);
       }
       public void Notify()
       {
           foreach (Investor investor in investors)
           {
               investor.Update(this);
           }
           Console.WriteLine("");
       }
       // Properties
       public double Price
       {
           get { return price; }
           set
           {
               price = value;
               Notify();
           }
       }
       public string Symbol
       {
           get { return symbol; }
           set { symbol = value; }
       }
    }
    class IBM : Stock
    {
        // Constructor
        public IBM(string symbol, double price)
            : base(symbol, price)
        {
        }
    }
    interface IInvestor
    {
        void Update(Stock stock);
    }
    class Investor : IInvestor
    {
        private string name;
        private Stock stock;
        public Stock Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                  "change to {2:C}", name, stock.Symbol, stock.Price);
        }
    }
}
