using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            Command command =new ConcreteCommand(receiver);
            Invoker invoke = new Invoker();

            invoke.SetCommand(command);
            invoke.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
