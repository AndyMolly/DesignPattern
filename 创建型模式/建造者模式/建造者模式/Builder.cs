using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式
{

    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
        }
    }
    abstract class Builder
    {
        public abstract void BuilderPartA();
        public abstract void BuilderPartB();
        public abstract Product GetProduct();
    }
    class ConcreateBuilder1 : Builder
    {
        Product product = new Product();
        public override void BuilderPartA()
        {
            product.Add("PartA");
        }

        public override void BuilderPartB()
        {
            product.Add("PartB");
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
    class ConcreateBuilder2 : Builder
    {
        Product product = new Product();
        public override void BuilderPartA()
        {
            product.Add("PartA");
        }

        public override void BuilderPartB()
        {
            product.Add("PartB");
        }

        public override Product GetProduct()
        {
            return product;
        }
    }

    class Product
    {
        ArrayList parts = new ArrayList();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("\n Product Parts------");
            foreach (var part in parts)
            {
                Console.WriteLine(part.ToString());
            }
        }
    }
}
