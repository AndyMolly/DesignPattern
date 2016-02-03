using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式例子2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Combo1 builder1 = new Combo1();
            Combo2 builder2 = new Combo2();
            customer.Construct(builder1);
            var product1= builder1.GetCombo();
            product1.Show();

            Console.WriteLine("\n");
            customer.Construct(builder2);
            var product2 = builder2.GetCombo();
            product2.Show();

            Console.ReadKey();

        }
    }
}
