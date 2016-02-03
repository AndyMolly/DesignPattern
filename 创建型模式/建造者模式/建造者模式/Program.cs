using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 *将一个复杂的对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示
 */
namespace 建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder builder1 = new ConcreateBuilder1();
            Builder builder2 = new ConcreateBuilder2();

            director.Construct(builder1);
            Product product1 = builder1.GetProduct();
            product1.Show();

            director.Construct(builder2);
            Product product2 = builder2.GetProduct();
            product2.Show();

            Console.ReadKey();
        }
    }
}
