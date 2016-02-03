using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式例子1
{
    class Item
    {
        private string name;
        public Item(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }
    interface IAbstractCollection
    {
        Iterator CreateIterator(); 
    }
    class Collection:IAbstractCollection
    {
        private ArrayList items = new ArrayList();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get { return items.Count; }
        }
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
    class Iterator:IAbstractIterator
    {
        private Collection collection;
        private int current = 0;
        private int step = 1;
        public Iterator(Collection collection)
        {
            this.collection = collection;
        }
        public Item First()
        {
            current = 0;
            return collection[current] as Item;
        }

        public Item Next()
        {
            current += step;
            if (!IsDone)
                return collection[current] as Item;
            else
                return null;
        }
        public int Step
        {
            get { return step; }
            set { step = value; }
        }
        public bool IsDone
        {
            get
            {
                return current >= collection.Count ? true : false;
            }
        }

        public Item CurrentItem
        {
            get
            {
                return collection[current] as Item;
            }
        }
    }
}
