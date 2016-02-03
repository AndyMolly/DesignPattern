using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式
{
    class FlyWeightFactory
    {
        private Hashtable flyweights = new Hashtable();
        public FlyWeightFactory()
        {
            flyweights.Add("X", new ConcreateFlyWeigth());
            flyweights.Add("Y", new ConcreateFlyWeigth());
            flyweights.Add("Z", new ConcreateFlyWeigth());
        }
        public FlyWeight GetFlyWeight(string key)
        {
            return (FlyWeight)flyweights[key];
        }
    }
   abstract class FlyWeight
    {
       public abstract void Operation(int extrinsicstate);
    }
   class ConcreateFlyWeigth : FlyWeight
   {

       public override void Operation(int extrinsicstate)
       {
           Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
       }
   }

   class UnsharedConcreateFlyWeight : FlyWeight
   {

       public override void Operation(int extrinsicstate)
       {
           Console.WriteLine("UnsharedConcreteFlyweight: " +
 extrinsicstate);
       }
   }
}
