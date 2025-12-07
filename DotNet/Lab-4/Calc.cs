using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Calc
    {
        public void add(int a , int b)
        {
            Console.WriteLine("Addition = " + (a + b));
        }
        public void add(int a, int b,int c)
        {
            Console.WriteLine("Addition = " + (a + b + c));
        }
        public void add(double a, double b)
        {
            Console.WriteLine("Addition = " + (a + b));
        }
    }
}
