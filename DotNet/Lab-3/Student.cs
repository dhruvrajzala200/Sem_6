using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Student
    {
        public String name;
        public int rollNo;
        public int marks;

        public void display()
        {
            Console.WriteLine("Name = " + this.name + " Roll no = " + this.rollNo + " Marks = " + this.marks);
        }
    }
}
