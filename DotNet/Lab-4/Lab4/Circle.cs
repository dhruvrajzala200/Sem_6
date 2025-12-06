using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Circle : Shape
    {
        public override void calculateArea()
        {
            Console.WriteLine("Enter Radius : ");
            int r = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Area of Rectangle = " + (3.14 * r * r));
        }
    }
}
