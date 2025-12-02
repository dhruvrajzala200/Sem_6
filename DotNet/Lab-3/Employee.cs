using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Employee
    {
        public int employeeID;
        public string employeeName;
        public int salary;
    
    public Employee(int employeeID, string employeeName, int salary) 
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.salary = salary;
        }

        public void display()
        {
            Console.WriteLine("employeeID = " + this.employeeID + " employeeName = " + this.employeeName + " salary = " + this.salary);
        }
    }
}
