using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 外观模式
{
    class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
        }
        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---------");
            one.MethodOne();
            two.MethodTwo();
        }
        public void MethodB()
        {
            Console.WriteLine("\nMethodB() --------");
            two.MethodTwo();
            three.MethodThree();
        }
    }
    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("SubSystemOne MethodOne");
        }
    }
    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("SubSystemTwo MethodTwo");
        }
    }
    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("SubSystemThree MethodThree");
        }
    }
}
