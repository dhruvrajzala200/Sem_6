using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Person
    {
        public string name = "Zala";
        private int age = 23;
        protected string city = "Dhrangdhra";
        internal int spi = 9;

        public void display()
        {
            Console.WriteLine("Private and protected from class : " + this.name + " " + this.city + " " + this.age + " " + this.spi);
        } 
    }
}
