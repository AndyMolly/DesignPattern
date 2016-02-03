using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();
            ab.Implementor = new ConcreateImplementorA();
            ab.Operation();

            ab.Implementor = new ConcreateImplementorB();
            ab.Operation();

            Console.ReadKey();
        }
    }
}
