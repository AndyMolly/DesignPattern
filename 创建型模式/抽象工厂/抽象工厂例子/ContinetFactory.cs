using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂例子
{
   abstract class ContinetFactory
    {
       public abstract Herbivore CreateHerbivore();
       public abstract Carnivore CreateCarnivore();
    }
   class AfricaFactory : ContinetFactory
   {

       public override Herbivore CreateHerbivore()
       {
           return new Wildebeest();
       }

       public override Carnivore CreateCarnivore()
       {
           return new Lion();
       }
   }

   class AmericaFactory : ContinetFactory
   {

       public override Herbivore CreateHerbivore()
       {
           return new Bison();
       }

       public override Carnivore CreateCarnivore()
       {
           return new Wolf();
       }
   }
    abstract class Herbivore
    {
    
    }
    abstract class Carnivore
    {
      public abstract void Eat(Herbivore h);
    }

    class Wildebeest : Herbivore
    { 
      
    }
    class Lion : Carnivore
    {

        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
    class Bison : Herbivore
    { 
      
    }
    class Wolf : Carnivore
    {

        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    class AnimalWorld
    {
        private Herbivore herbivore;
        private Carnivore carnivore;
        public AnimalWorld(ContinetFactory factory)
        {
            herbivore = factory.CreateHerbivore();
            carnivore = factory.CreateCarnivore();
        }
        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}
