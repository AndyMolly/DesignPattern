using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂例子2
{
   abstract class CarDoorFactory
    {
       public abstract CarDoor CreaterDoor();
    }
   class BenChiDoorFactory : CarDoorFactory 
   {

       public override CarDoor CreaterDoor()
       {
           return new BenChiDoor();
       }
   }
   class BaoMaDoorFactory : CarDoorFactory
   {

       public override CarDoor CreaterDoor()
       {
           return new BaoMaDoor();
       }
   }
    
    abstract class CarDoor
    {
      public abstract void Door();
    }
    class BenChiDoor:CarDoor
    {

        public override void Door()
        {
            Console.WriteLine("this is benchi door");
        }
    }
    class BaoMaDoor : CarDoor
    {

        public override void Door()
        {
            Console.WriteLine("this is  baoma door");
        }
    }

    class Client
    {
        CarDoor carDoor;
        public Client(CarDoorFactory factory)
        {
           carDoor= factory.CreaterDoor();
        }
        public void Run()
        {
            carDoor.Door();
        }
    }
}
