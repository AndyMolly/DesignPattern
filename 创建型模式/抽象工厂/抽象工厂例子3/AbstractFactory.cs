using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂例子3
{
    public interface Fruit
    {
        string GetFruitName();
        void SetFruitName(string name);
    }
    public interface Veggie
    {
        string GetVeggieName();
        void SetVeggieName(string name);
    }

    class NorthFruit : Fruit
    {
        string name = "Apple";
        public string GetFruitName()
        {
            return name;
        }

        public void SetFruitName(string name)
        {
            this.name = name;
        }
    }
    class SouthFruit : Fruit
    {
        string name = "bananle";
        public string GetFruitName()
        {
            return name;
        }

        public void SetFruitName(string name)
        {
            this.name = name;
        }
    }
    class NorthVeggie : Veggie 
    {
        string name = "白菜";
        public string GetVeggieName()
        {
            return name;
        }

        public void SetVeggieName(string name)
        {
            this.name = name;
        }
    }
    class SouthVeggie : Veggie
    {
        string name="卷芯菜";
        public string GetVeggieName()
        {
            return name;
        }

        public void SetVeggieName(string name)
        {
            this.name = name;
        }
    }
    public interface Factory
    {
         Fruit CreateFruit();
         Veggie CreateVeggie();
    }
    class NorthFactory : Factory
    {

        public Fruit CreateFruit()
        {
            return new NorthFruit();
        }

        public Veggie CreateVeggie()
        {
            return new NorthVeggie();
        }
    }
    class SouthFactory : Factory
    {

        public Fruit CreateFruit()
        {
            return new SouthFruit();
        }

        public Veggie CreateVeggie()
        {
            return new SouthVeggie();
        }
    }

}
