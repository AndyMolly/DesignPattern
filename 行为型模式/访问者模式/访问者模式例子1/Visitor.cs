using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 访问者模式例子1
{
    interface IVisitor
    {
        void Visit(Element element);
    }
    class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;
            // Provide 10% pay raise
            employee.Income *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}",


                employee.GetType().Name, employee.Name,
            employee.Income);
        }
    }
    class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;
            // Provide 3 extra vacation days
            Console.WriteLine("{0} {1}'s new vacation days: {2}",
            employee.GetType().Name, employee.Name,
            employee.VacationDays);
        }
    }
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
// "ConcreteElement"
    class Employee : Element
    {
        string name;
        double income;
        int vacationDays;
        // Constructor
        public Employee(string name, double income,
        int vacationDays)
        {
            this.name = name;
            this.income = income;
            this.vacationDays = vacationDays;
        }
        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Income
        {
            get { return income; }
            set { income = value; }
        }
        public int VacationDays
        {
            get { return vacationDays; }
            set { vacationDays = value; }
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    class Clerk : Employee
    {
        // Constructor
        public Clerk()
            : base("Hank", 25000.0, 14)
        {
        }
    }
    class Director : Employee
    {
        // Constructor
        public Director()
            : base("Elly", 35000.0, 16)
        {
        }
    }
    class President : Employee
    {
        // Constructor
        public President()
            : base("Dick", 45000.0, 21)
        {
        }
    }
    class Employees
    {
        private ArrayList employees = new ArrayList();
        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }
        public void Detach(Employee employee)
        {
            employees.Remove(employee);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (Employee e in employees)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}


