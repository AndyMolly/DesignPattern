using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式例子1
{
    class Program
    {
        static void Main(string[] args)
        {
            Color c = new Color(255, 0, 0);
           var clone= c.Clone() as Color;
           Console.WriteLine("Color clone is {0}  {1}   {2}",clone.Red,clone.Green,clone.Blue);
           Console.ReadKey();
        }
    }
}
