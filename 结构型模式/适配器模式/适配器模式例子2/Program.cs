using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式例子2
{
    class Program
    {
        static void Main(string[] args)
        {
            Compound stuff = new Compound("UnKnown");
            stuff.Display();

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound alcohol = new RichCompound("Alcohol");
            alcohol.Display();

            Console.ReadKey();
        }
    }
}
