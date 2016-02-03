using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式例子1
{

    class Shop
    {
        public void Construct(VehicleBuilder builder)
        {
            builder.BuilderFrame();
            builder.BuilderEngine();
            builder.BuilderWheels();
            builder.BuilderDoors();
        }
    }
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }
        public abstract void BuilderFrame();
        public abstract void BuilderEngine();
        public abstract void BuilderWheels();
        public abstract void BuilderDoors();
    }
    class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }
        public override void BuilderFrame()
        {
            vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuilderEngine()
        {
            vehicle["engine"] = "MotorCycle Engine";
        }

        public override void BuilderWheels()
        {
            vehicle["wheels"] = "MotorCycle Wheels";
        }

        public override void BuilderDoors()
        {
            vehicle["doors"] = "MotorCycle Doors";
        }
    }
    class CarBuilder:VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public override void BuilderFrame()
        {
            vehicle["frame"] = "Car Frame";
        }

        public override void BuilderEngine()
        {
            vehicle["engine"] = "Car Engine";
        }

        public override void BuilderWheels()
        {
            vehicle["wheels"] = "Car Wheels";
        }

        public override void BuilderDoors()
        {
            vehicle["doors"] = "Car Doors";
        }
    }
    class Vehicle
    {
        private string type;
        public Hashtable parts = new Hashtable();
        public Vehicle(string type)
        {
            this.type = type;
        }
        public object this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n--------------------");
            Console.WriteLine("Vehicle Type :{0}", type);
            Console.WriteLine("Frame :{0}", parts["frame"]);
            Console.WriteLine("Engine:{0}", parts["engine"]);
            Console.WriteLine("Wheels:{0}", parts["wheels"]);
            Console.WriteLine("Doors:{0}", parts["doors"]);
        }
    }

}
