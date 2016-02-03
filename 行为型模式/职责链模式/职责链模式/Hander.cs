using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式
{
   abstract class Handler
    {
       protected Handler successor;
       public void SetSucessor(Handler successor)
       {
           this.successor = successor;
       }
       public abstract void HandleRequest(int request);

    }
   class ConcreteHandler1 : Handler
   {
       public override void HandleRequest(int request)
       {
           if (request >= 0 && request < 10)
           {
               Console.WriteLine("{0} handled request {1}",
               this.GetType().Name, request);
           }
           else if (successor != null)
           {
               successor.HandleRequest(request);
           }
       }
   }
   class ConcreteHandler2 : Handler
   {

       public override void HandleRequest(int request)
       {
           if (request >= 10 && request < 20)
           {
               Console.WriteLine("{0} handled request {1}",
               this.GetType().Name, request);
           }
           else if (successor != null)
           {
               successor.HandleRequest(request);
           }
       }
   }
    class ConcreteHandler3 : Handler
     {
        public override void HandleRequest(int request)
        {
           if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} handled request {1}",
                this.GetType().Name, request);
            }
            else if (successor != null)
            {
              successor.HandleRequest(request);
            }
        }
    }


}
