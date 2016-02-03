using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
   abstract class Component
   {
       protected string name;

       public Component(string name)
       {
           this.name = name;
       }

       public abstract void Add(Component c);
       public abstract void Remove(Component c);
       public abstract void DisPlay(int depth);
   }

    class  Composite:Component
    {
        private ArrayList children = new ArrayList();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }

        public override void DisPlay(int depth)
        {
            Console.WriteLine(new string('-',depth)+name);
            foreach (Component child in children)
            {
                child.DisPlay(depth+2);
            }
        }
    }

    class  Leaf:Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Leaf Con not Add ");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Leaf Con not Remove ");
        }

        public override void DisPlay(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
   
}
