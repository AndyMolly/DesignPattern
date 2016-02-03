using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式
{
   abstract class Aggregate
    {
       public abstract Iterator CreateIterator();
     }
   class ConcreteAggregate : Aggregate 
   {
       private ArrayList items = new ArrayList();
       public int Count
       {
           get { return items.Count; }
       }
       public object this[int index]
       {
           get { return items[index]; }
           set { items.Insert(index,value); }
       }

       public override Iterator CreateIterator()
       {
           return new ConcreteIterator(this);
       }
   }
   abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
   class ConcreteIterator : Iterator
   {
       private ConcreteAggregate aggregate;
       private int current;
       public ConcreteIterator(ConcreteAggregate aggregate)
       {
         this.aggregate=aggregate;
       }
       public override object First()
       {
           return aggregate[0];
       }

       public override object Next()
       {
           object ret = null;
           if (current < aggregate.Count - 1)
           {
               ret = aggregate[++current];
           }
           return ret;
       }

       public override bool IsDone()
       {
           return current >= aggregate.Count ? true : false;
       }

       public override object CurrentItem()
       {
           return aggregate[current];
       }
   }
}
