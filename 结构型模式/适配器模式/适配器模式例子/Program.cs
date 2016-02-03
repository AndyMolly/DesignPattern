using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式例子
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new LabelLine();
            line.Render();

            Console.ReadKey();
        }
    }
}
