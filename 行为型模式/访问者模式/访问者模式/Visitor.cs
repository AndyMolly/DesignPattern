using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式
{
    abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }
    class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}",
concreteElementA.GetType().Name, this.GetType().Name);
        }
        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}",
                 concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
    class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(
        ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}",
            concreteElementA.GetType().Name, this.GetType().Name);
        }
        public override void VisitConcreteElementB(
        ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}",
            concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
    class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
        public void OperationA()
        {
        }
    }
    class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
        public void OperationB()
        {
        }
    }
    class ObjectStructure
    {
        private ArrayList elements = new ArrayList();
        public void Attach(Element element)
        {
            elements.Add(element);
        }
        public void Detach(Element element)
        {
            elements.Remove(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (Element e in elements)
            {
                e.Accept(visitor);
            }
        }
    }
}
