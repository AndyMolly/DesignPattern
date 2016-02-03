using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式
{
    abstract class Product
    { 
    
    }

    class ProductA : Product
    { 
      
    }
    class ProductB : Product
    { 
    
    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
    class CreatorA : Creator
    {

        public override Product FactoryMethod()
        {
            return new ProductA();
        }

    }
    class CreatorB : Creator
    {

        public override Product FactoryMethod()
        {
           return new ProductB();
        }
    }
}
