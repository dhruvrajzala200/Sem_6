using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    public interface IPrintable
    {
        public void PrintDetails();
    }

    public class Book : IPrintable
    {
        public void PrintDetails()
        {
            Console.WriteLine("Hello form book");
        }
    }

    public class Magzine : IPrintable 
    {
        public void PrintDetails() 
        {
            Console.WriteLine("Hello form Magzine");
        }
    }


}
