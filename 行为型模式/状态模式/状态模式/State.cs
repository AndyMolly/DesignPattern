using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
   abstract class State
    {
       public abstract void Handle(Context context);
    }
   class ConcreteStateA : State
   {
       public override void Handle(Context context)
       {
           context.State = new ConcreteStateB();
       }
   }
   class ConcreteStateB : State
   {
       public override void Handle(Context context)
       {
           context.State = new ConcreteStateA();
       }
   }
   class Context
   {
       private State state;
       public Context(State state)
       {
           this.state = state;
       }

       public State State
       {
           get { return state; }
           set {
               state = value;
               Console.WriteLine("State: " +
                        state.GetType().Name);
           }
       }
       public void Request()
       {
           state.Handle(this);
       }
   }
}
