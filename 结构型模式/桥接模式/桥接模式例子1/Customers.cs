using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式例子1
{
    class CustomersBase
    {
        private DataObject dataObject;
        protected string group;
        public CustomersBase(string group)
        {
            this.group = group;
        }
        public DataObject Data
        {
            get { return dataObject; }
            set { dataObject = value; }
        }

        public virtual void Next()
        {
            dataObject.NextRecord();
        }
        public virtual void Prior()
        {
            dataObject.PriorRecord();
        }
        public virtual void New(string name)
        {
            dataObject.NewRecord(name);
        }
        public virtual void Show()
        {
            dataObject.ShowRecord();
        }
        public virtual void ShowAll()
        {
            Console.WriteLine("Customer Group:" + group);
            dataObject.ShowAllRecords();
        }
    }
    abstract class DataObject
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void NewRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract void ShowRecord();
        public abstract void ShowAllRecords();

    }
    class Customers:CustomersBase
    {
        public Customers(string group)
            : base(group)
        { }
        public override void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("------------------");
            base.ShowAll();
            Console.WriteLine("------------------");
        }
    }
    class CustomersData : DataObject
    {
        private ArrayList customers = new ArrayList();
        private int current = 0;
        public CustomersData()
        {
          customers.Add("Andy");
          customers.Add("Molly");
          customers.Add("Jack");
          customers.Add("Jim");
          customers.Add("Kur");
        }
        public override void NextRecord()
        {
            if (current > 0)
                current++;
        }
        public override void PriorRecord()
        {
            if (current > 0)
                current--;
        }
        public override void NewRecord(string name)
        {
            customers.Add(name);
        }
        public override void DeleteRecord(string name)
        {
            customers.Remove(name);
        }
        public override void ShowRecord()
        {
            Console.WriteLine(customers[current]);
        }
        public override void ShowAllRecords()
        {
            foreach (var name in customers)
            {
                Console.WriteLine(" " + name);
            }
        }

    }
}
