using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    public abstract class Employee
    {
        public string name;
        public int salary;

        public abstract double CalculateBonus();
    }
    public class Manager : Employee
    {
        public Manager(string name, int sal)
        {
            this.name = name;
            this.salary = sal;
        }
        public override double CalculateBonus()
        {
            return this.salary * 0.2;
        }
    }
    public class Developer : Employee
    {
        public Developer(string name, int sal)
        {
            this.name = name;
            this.salary = sal;
        }
        public override double CalculateBonus()
        {
            return this.salary * 0.1;
        }
    }
}
