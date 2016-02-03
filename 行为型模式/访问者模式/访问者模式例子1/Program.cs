using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式例子1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            Console.Read();
        }
    }
}
