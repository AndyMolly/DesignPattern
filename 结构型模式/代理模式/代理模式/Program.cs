using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();

            Console.ReadKey();
        }
    }
}
