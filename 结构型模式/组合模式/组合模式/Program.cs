using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root=new Composite("root");
             root.Add(new Leaf("Leag A"));
             root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Composite XA"));
            comp.Add(new Leaf("Composite XB"));

            root.Add(comp);
            root.Add(new Leaf("C"));
            root.DisPlay(1);

            Console.ReadKey();
        }
    }
}
