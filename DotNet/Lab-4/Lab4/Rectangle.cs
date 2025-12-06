using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Rectangle : Shape
    {
        public override void calculateArea()
        {
            Console.WriteLine("Enter length : ");
            int len = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter breadth : ");
            int bre = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of Rectangle = " + (len*bre));
        }
    }
}
