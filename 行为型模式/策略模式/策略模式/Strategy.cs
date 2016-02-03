using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
   abstract class Strategy
    {
       public abstract void AlgorithmInterface();
    }
   class ConcreStrategyA : Strategy
   {

       public override void AlgorithmInterface()
       {
           Console.WriteLine(
                "Called ConcreteStrategyA.AlgorithmInterface()");
       }
   }
   class ConcreteStrategyB : Strategy
   {
       public override void AlgorithmInterface()
       {
           Console.WriteLine(
           "Called ConcreteStrategyB.AlgorithmInterface()");
       }
   }
   class ConcreteStrategyC : Strategy
   {
       public override void AlgorithmInterface()
       {
           Console.WriteLine(
           "Called ConcreteStrategyC.AlgorithmInterface()");
       }
   }
   class Context
   {
       Strategy strategy;
       public Context(Strategy strategy)
       {
           this.strategy = strategy;
       }
       public void ContextInterface()
       {
           strategy.AlgorithmInterface();
       }
   }
}
