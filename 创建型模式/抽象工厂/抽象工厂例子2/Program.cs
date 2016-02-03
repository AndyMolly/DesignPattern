using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂例子2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDoorFactory factory = new BenChiDoorFactory();
            Client l1 = new Client(factory);
            l1.Run();

            CarDoorFactory factory2 = new BaoMaDoorFactory();
            Client l2 = new Client(factory2);
            l2.Run();

            Console.ReadKey();
        }
    }
}
