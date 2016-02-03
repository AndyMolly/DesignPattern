using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 *抽象工厂模式可以向客户端提供一个接口，使客户端在不必指定具体产品的情况下，创建多个产品族中的产品对象。
 *抽象工厂模式，可以处理具有相同（或者相似）等级结构的多个产品族中的产品对象的创建问题。
 *由于每个具体工厂角色都需要负责两个不同等级结构的产品对象的创建，因此每个工厂角色都需要提供两个工厂方法，分别用于创建两个等级结构的产品。
 *既然每个具体工厂角色都需要实现这两个工厂方法，所以具有一般性，不妨抽象出来，移动到抽象工厂角色中加以声明。
 *对于每一个产品族，都有一个具体工厂。而每一个具体工厂创建属于同一个产品族，但是分属于不同等级结构的产品。
 */
namespace 抽象工厂
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
    class Factory1:AbstractFactory
    {

        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
    class Factory2 : AbstractFactory
    {

        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    abstract class AbstractProductA
    { 
    
    }
    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    class ProductA1 : AbstractProductA
    { 
      
    }
    class ProductB1 : AbstractProductB
    {

        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interats With" + a.GetType().Name);
        }
    }
    class ProductA2 : AbstractProductA
    { 
      
    }
    class ProductB2 : AbstractProductB
    {

        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interats With" + a.GetType().Name);
        }
    }
    class Client
    {
        private AbstractProductA _abstract_productA;
        private AbstractProductB _abstract_productB;
        public Client(AbstractFactory factory)
        {
            _abstract_productA = factory.CreateProductA();
            _abstract_productB = factory.CreateProductB();
        }
        public void Run()
        {
            _abstract_productB.Interact(_abstract_productA);
        }
    }
}
