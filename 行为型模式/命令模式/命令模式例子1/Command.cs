using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式例子1
{
   abstract class Command
    {
       public abstract void Execute();
       public abstract void UnExecute();
    }
   class CalculatorCommand : Command
   {
       char @operator;
       int oprand;
       Calculator calculator;
       public CalculatorCommand(Calculator calculator, char @operator, int oprand)
       {
           this.@operator = @operator;
           this.oprand = oprand;
           this.calculator = calculator;
       }
       public override void Execute()
       {
           calculator.Operation(@operator, oprand);
       }

       public override void UnExecute()
       {
           calculator.Operation(Undo(@operator), oprand);
       }
       private char Undo(char @operator)
       {
           char undo;
           switch (@operator)
           {
               case '+': undo = '-'; break;
               case '-': undo = '+'; break;
               case '*': undo = '/'; break;
               case '/': undo = '*'; break;
               default: undo = ' '; break;
           }
           return undo;
       }
   }
   class Calculator
   {
       private int curr = 0;
       public void Operation(char @operator, int operand)
       {
           switch (@operator)
           {
               case '+': curr += operand; break;
               case '-': curr -= operand; break;
               case '*': curr *= operand; break;
               case '/': curr /= operand; break;
           }
           Console.WriteLine(
           "Current value = {0,3} (following {1} {2})",
           curr, @operator, operand);
       }
   }

   class User
   { 
        private Calculator calculator = new Calculator();
        private ArrayList commands = new ArrayList();
        private int current = 0;
        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    Command command = commands[current++] as Command;
                    command.Execute();
                }
            }
        }
        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command command = commands[--current] as Command;
                    command.UnExecute();
                }
            }
        }
        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(
            calculator, @operator, operand);
            command.Execute();
            // Add command to undo list
            commands.Add(command);
            current++;
        }
   }
}
