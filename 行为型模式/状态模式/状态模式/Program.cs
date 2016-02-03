using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStateA());

            context.Request();
            context.Request();

            Console.Read();
        }
    }
}
