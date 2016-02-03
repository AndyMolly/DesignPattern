using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式例子1
{
    class Program
    {
        static void Main(string[] args)
        {
            ILegendFactory factory = new SymbolFactory();
           Console.WriteLine( factory.Create().Name);
           Console.ReadKey();
        }
    }
}
