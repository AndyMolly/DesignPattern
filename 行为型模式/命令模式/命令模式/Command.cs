using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
   abstract class Command
    {
      protected Receiver receiver;
       public Command(Receiver receiver)
       {
           this.receiver = receiver;
       }
       public abstract void Execute();
    }
   class Receiver
   {
       public void Action()
       {
           Console.WriteLine("Called Receiver.Action()");
       }
   }
   class ConcreteCommand : Command
   {
       public ConcreteCommand(Receiver receiver)
           : base(receiver)
       { }
       public override void Execute()
       {
           receiver.Action();  
       }
   }
   class Invoker
   {
       private Command command;
       public void SetCommand(Command command)
       {
           this.command = command;
       }
       public void ExecuteCommand()
       {
           command.Execute();
       }
   }
}
