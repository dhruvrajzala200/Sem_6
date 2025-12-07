using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class LibraryItem
    {
        public string name;
        string title
        public int price;

        public LibraryItem(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name of LibraryItem : " + this.name);
            Console.WriteLine("Descrp of LibraryItem : " + this.description);
            Console.WriteLine("Price of LibraryItem : " + this.price);
            Console.WriteLine();
        }
    }
}
