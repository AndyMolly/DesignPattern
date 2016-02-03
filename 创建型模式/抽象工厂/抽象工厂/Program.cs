using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory1 = new Factory1();
            Client cl1 = new Client(factory1);
            cl1.Run();

            AbstractFactory factory2 = new Factory2();
            Client cl2 = new Client(factory2);
            cl2.Run();

            Console.ReadKey();
        }
    }
}
