using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 代理模式例子1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyMath p = new ProxyMath();

            Console.WriteLine("4 + 2 = " + p.Add(4, 2));
            Console.WriteLine("4 - 2 = " + p.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + p.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + p.Div(4, 2));

            Console.ReadKey();
        }
    }
}
