using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Template template;
            template = new ConcreteClassA();
            template.TemplateMethod();

            template = new ConcretaClassB();
            template.TemplateMethod();

            Console.ReadKey();
        }
    }
}
