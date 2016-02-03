using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式
{
    class Originator
    {
        private string state;
        public string State
        {
            get { return state; }
            set {
                state = value;
                Console.WriteLine("State = " + state);
            }
        }
        public Memento CreateMemento()
        {
            return new Memento(state);
        }
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state:");
            State = memento.State;
        }
    }
    class Memento
    {
        private string state;
        public string State
        {
            get { return state; }
        }
        public Memento(string state)
        {
            this.state = state;
        }
    }
    class Caretaker
    {
        Memento memento;
        public Memento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
