using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装饰模式
{
    abstract class Component
    {
        public abstract void Operation();
    }

    class  ConcreateComponet:Component
    {

        public override void Operation()
        {
           Console.WriteLine("ConcreateComponet.Operation()");
        }
    }
   abstract class Decorator:Component
   {
       protected Component component;

       public void SetDecorator(Component component)
       {
           this.component = component;
       }

       public override void Operation()
        {
           if(component!=null)
               component.Operation();
        }
    }

    class  ConcreateDecoratorA:Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("ConcreateDecoratorA.Operation()");
        }
    }
    class ConcreateDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();

            AddMethod();

            Console.WriteLine("ConcreateDecoratorB.Operation()");
        }

        void AddMethod()
        {
        }
    }
}
