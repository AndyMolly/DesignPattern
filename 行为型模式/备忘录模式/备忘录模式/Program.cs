using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {

            Originator o = new Originator();
            o.State = "On";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";
            o.SetMemento(c.Memento);

            Console.ReadKey();
        }
    }
}
