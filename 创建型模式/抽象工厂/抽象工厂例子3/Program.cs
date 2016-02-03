using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂例子3
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory1 = new NorthFactory();
           var fruit=  factory1.CreateFruit();
           Console.WriteLine(fruit.GetFruitName());
           Console.ReadKey();

        }
    }
}
