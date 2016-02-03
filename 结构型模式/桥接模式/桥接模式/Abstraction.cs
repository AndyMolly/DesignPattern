using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式
{
    class Abstraction
    {
        protected Implementor _imolementor;
        public Implementor Implementor
        {
            set { _imolementor = value; }
        }
        public virtual void Operation()
        {
            if(_imolementor!=null)
               _imolementor.Operation();
        }
    }
    abstract class Implementor
    {
        public abstract void Operation();
    }

    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            _imolementor.Operation();
        }
    }
    class ConcreateImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreateImplementorA Operation");
        }
    }
    class ConcreateImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreateImplementorB Operation");
        }
    }
}
