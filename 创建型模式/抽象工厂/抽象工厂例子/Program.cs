using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂例子
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory1 = new AfricaFactory();
            AnimalWorld an1 = new AnimalWorld(factory1);
            an1.RunFoodChain();

            var factory2 = new AmericaFactory();
            AnimalWorld an2 = new AnimalWorld(factory2);
            an2.RunFoodChain();

            Console.ReadKey();
        }
    }
}
