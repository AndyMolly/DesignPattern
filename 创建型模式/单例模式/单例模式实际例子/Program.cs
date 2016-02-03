using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例模式实际例子
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1=LoadBalancer.GetInstance();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(b1.Server);
            }
            Console.ReadKey();
        }
    }
}
