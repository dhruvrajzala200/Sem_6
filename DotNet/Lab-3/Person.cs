using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Person
    {
        public string name;
        public int age;
        public int id;

        public Person()
        {
            this.name = "hallloooo";
            this.age = 1;
            this.id = 1;
        }

        public Person(String nams)
        {
            this.name = nams;
        }

        public Person(String nams, int age)
        {
            this.age = age;
            this.name = nams;
        }

        public Person(String nams, int age, int id)
        {
            this.age = age;
            this.name = nams;
            this.id = id;
        }

        public void display()
        {
            Console.WriteLine("Name = "+this.name+" Age = "+this.age+" Id = "+this.id);
        }
    }
}
