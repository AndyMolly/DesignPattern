using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            ArrayList list = new ArrayList();
            list.Add(new TerminalExpression());

            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            Console.ReadKey();
        } 
    }
}
