using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request");
        }
    }
    class Adapter:Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            //Todo something
            adaptee.SpecificRequest();
        }
    }
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest");
        }
    }
}
