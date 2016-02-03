using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 中介者模式
{
   abstract class Mediator
    {
       public abstract void Send(string message, Colleague colleague);
    }
   class ConcreteMediator : Mediator
   {
       private ConcreteColleague1 colleague1;
       private ConcreteColleague2 colleague2;
       public ConcreteColleague1 Colleague1
       {
           set { colleague1 = value; }
       }
       public ConcreteColleague2 Colleague2
       {
           set { colleague2 = value; }
       }

       public override void Send(string message, Colleague colleague)
       {
           if (colleague == colleague1)
           {
               colleague2.Notify(message);
           }
           else
           {
               colleague1.Notify(message);
           }
       }
   }
    abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
    class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator)
            : base(mediator)
        { 
        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: " + message);
        }
    }
    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator)
            : base(mediator)
        { 
        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: " + message);
        }
    }
}
