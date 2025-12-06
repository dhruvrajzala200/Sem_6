using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Book : LibraryItem
    {
        public string name;
        public string title;
        public string author;
        public int price;

        public Book(string name, string title, string author, int price) : base(name, title, price)
        {
            this.name = name;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Name of Book : " + this.name);
            Console.WriteLine("Title of Book: " + this.title);
            Console.WriteLine("Author of Book: " + this.author);
            Console.WriteLine("Price of Book: " + this.price);
            Console.WriteLine();
        }
    }
}
