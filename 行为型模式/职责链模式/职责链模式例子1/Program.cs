using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式例子1
{
    class Program
    {
        static void Main(string[] args)
        {
            Director Larry = new Director();
            VicePresident Sam = new VicePresident();
            President Tammy = new President();

            Larry.SetSuccessor(Sam);
            Sam.SetSuccessor(Tammy);
            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.00, "Supplies");
            Larry.ProcessRequest(p);
            p = new Purchase(2035, 32590.10, "Project X");
            Larry.ProcessRequest(p);
            p = new Purchase(2036, 122100.00, "Project Y");
            Larry.ProcessRequest(p);
            // Wait for user
            Console.Read();

        }
    }
}
