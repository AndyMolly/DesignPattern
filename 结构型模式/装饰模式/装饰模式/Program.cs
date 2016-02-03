using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreateComponet c=new ConcreateComponet();
            ConcreateDecoratorA d1 = new ConcreateDecoratorA();
            ConcreateDecoratorB d2 = new ConcreateDecoratorB();

            d1.SetDecorator(c);
            d2.SetDecorator(d1);

            d2.Operation();

            Console.ReadKey();
        }
    }
}
