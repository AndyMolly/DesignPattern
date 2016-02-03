using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace 组合模式例子1
{
   abstract class DrawingElement
    {
        protected string name;

       public DrawingElement(string name)
       {
           this.name = name;
       }

        public abstract void Add(DrawingElement c);
        public abstract void Remove(DrawingElement c);
       public abstract void DisPlay(int indent);
    }

    /// <summary>
    /// composite
    /// </summary>
    class CompositeElement:DrawingElement
    {
        private List<DrawingElement> elements = new List<DrawingElement>();

        public CompositeElement(string name) : base(name)
        {
            
        }
        public override void Add(DrawingElement c)
        {
            elements.Add(c);
        }

        public override void Remove(DrawingElement c)
        {
            elements.Remove(c);
        }

        public override void DisPlay(int indent)
        {
            Console.WriteLine(new string('-', indent) + name);
            foreach (DrawingElement element in elements)
            {
                element.DisPlay(indent + 2);
            }
        }
    }

    /// <summary>
    /// Leaf
    /// </summary>
   class PrimitiveElement:DrawingElement
    {
       public PrimitiveElement(string name) : base(name)
       {
       }

       public override void Add(DrawingElement c)
        {
          Console.WriteLine("Con not add to PrimitiveElement");
        }

        public override void Remove(DrawingElement c)
        {
            Console.WriteLine("Con not remove from PrimitiveElement");
        }

        public override void DisPlay(int indent)
        {
            Console.WriteLine(new string('-', indent) + name);
        }
    }
}
