using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConCreateProtoType1 p1 = new ConCreateProtoType1("1");
            var c1=  p1.Clone() as ConCreateProtoType1;

            Console.WriteLine("Cloned {0}", c1.ID);

            ConCreateProtoType2 p2 = new ConCreateProtoType2("2");
            var c2 = p2.Clone();
            Console.WriteLine("Cloned {0}", c2.ID);

            Console.ReadKey();
        }
    }
}
