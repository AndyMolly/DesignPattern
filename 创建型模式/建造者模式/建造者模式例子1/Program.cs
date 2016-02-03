using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式例子1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            MotorCycleBuilder builder1 = new MotorCycleBuilder();
            CarBuilder builder2 = new CarBuilder();
            shop.Construct(builder1);
            builder1.Vehicle.Show();

            shop.Construct(builder2);
            builder2.Vehicle.Show();

            Console.ReadKey();
        }
    }
}
