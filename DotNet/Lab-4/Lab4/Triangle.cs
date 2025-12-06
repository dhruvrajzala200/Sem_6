using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class Triangle : Shape
    {
        public override void calculateArea()
        {
            Console.WriteLine("Enter Height : ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Base : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of Rectangle = " + (0.5 *h *b));
        }
    }
}
