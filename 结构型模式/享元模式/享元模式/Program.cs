using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 22;
            FlyWeightFactory f = new FlyWeightFactory();
            // Work with different flyweight instances
            FlyWeight fx = f.GetFlyWeight("X");
            fx.Operation(--extrinsicstate);
            FlyWeight fy = f.GetFlyWeight("Y");
            fy.Operation(--extrinsicstate);
            FlyWeight fz = f.GetFlyWeight("Z");
            fz.Operation(--extrinsicstate);
            UnsharedConcreateFlyWeight fu = new
            UnsharedConcreateFlyWeight();
            fu.Operation(--extrinsicstate);
            // Wait for user
            Console.Read();
        }
    }
}
