using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Employee
    {

        public void display(string name)
        {
            Console.WriteLine("Name = " + name);
        }
        public void display(string name, int age)
        {
            Console.WriteLine("Name = " + name + " Age = " + age);
        }
        public void display(string name, int age, int salary)
        {
            Console.WriteLine("Name = " + name + " Age = " + age + " Salary = " + salary);
        }
    }
}
