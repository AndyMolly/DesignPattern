using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();
            Handler handler3 = new ConcreteHandler3();
            handler2.SetSucessor(handler1);
            handler3.SetSucessor(handler2);

            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (var request in requests)
            {
                handler3.HandleRequest(request);
            }

            Console.ReadKey();
        }
    }
}
