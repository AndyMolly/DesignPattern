using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式例子1
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));
            CompositeElement comp =
            new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);
            // Add and remove a PrimitiveElement
            PrimitiveElement pe =
            new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);
            // Recursively display nodes
            root.DisPlay(1);
            Console.ReadKey();
        }
    }
}
