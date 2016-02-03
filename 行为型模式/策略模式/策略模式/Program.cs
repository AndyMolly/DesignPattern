using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context=new Context(new ConcreStrategyA());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
            // Wait for user
            Console.Read();
        }
    }
}
