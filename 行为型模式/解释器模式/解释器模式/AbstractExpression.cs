using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式
{
    class Context { }
   abstract class AbstractExpression
    {
       public abstract void Interpret(Context context);
    }
   class TerminalExpression : AbstractExpression
   {

       public override void Interpret(Context context)
       {
           Console.WriteLine("Called Terminal.Interpret()");
       }
   }
   class NonterminalExpression : AbstractExpression
   {
       public override void Interpret(Context context)
       {
           Console.WriteLine("Called Nonterminal.Interpret()");
       }
   }
}
