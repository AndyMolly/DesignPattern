using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式例子1
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);
            // Build the 'parse tree'
            ArrayList tree = new ArrayList();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());
            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }
            Console.WriteLine("{0} = {1}",
            roman, context.Output);
            // Wait for user
            Console.Read();
        }
    }
}
