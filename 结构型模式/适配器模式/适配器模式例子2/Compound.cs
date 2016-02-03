using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式例子2
{
    class Compound
    {
        protected string name;
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecurlarWeight;
        protected string molecurlarFormular;

        public Compound(string name)
        {
            this.name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine("\nCompound:{0}---------", name);
        }
    }
    class RichCompound : Compound
    {
        private ChemicalDatabank bank;

        public RichCompound(string name):base(name)
        { 
        
        }
        public override void Display()
        {
            bank = new ChemicalDatabank();
            boilingPoint = bank.GetCriticalPoint(name, "B");
            meltingPoint = bank.GetCriticalPoint(name, "M");
            molecurlarWeight = bank.GetMelecularWeight(name);
            molecurlarFormular = bank.GetMolecularStructure(name);

            base.Display();

            Console.WriteLine(" Formular:{0}", molecurlarFormular);
            Console.WriteLine(" Weight:{0}", molecurlarWeight);
            Console.WriteLine(" Melting Pt:{0}", meltingPoint);
            Console.WriteLine(" Boiling Pt:{0}", boilingPoint);
        }
    }

    class ChemicalDatabank
    {
        public float GetCriticalPoint(string compound, string point)
        {
            float temperature = 0.0f;
            if (point == "M")
            {
                switch (compound)
                {
                    case "water":
                        temperature = 0.0f;
                        break;
                    case "benzene":
                        temperature = 5.5f;
                        break;
                    case "alcohol":
                        temperature = -114.1f;
                        break;
                }
            }
            else
            {
                switch (compound.ToLower())
                {
                    case "water":
                        temperature = 100.0f;
                        break;
                    case "benzene":
                        temperature = 80.1f;
                        break;
                    case "alcohol":
                        temperature = 78.3f;
                        break;
                }
            }
            return temperature;
        }
        public string GetMolecularStructure(string compound)
        {
            string structure = "";
            switch (compound)
            {
                case "water":
                    structure ="H20";
                    break;
                case "benzene":
                    structure = "C6H6";
                    break;
                case "alcohol":
                    structure = "C2H602";
                    break;
            }
            return structure;
        }
        public double GetMelecularWeight(string compound)
        {
            double weight = 0.0;
            switch (compound.ToLower())
            {
                case "water": weight = 18.015; break;
                case "benzene":
                    weight = 78.1134;
                    break;
                case "alcohol":
                    weight = 46.0688;
                    break;
            }
            return weight;
        }
       
    }
    
}
