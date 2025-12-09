using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    public class Shape
    {
        public virtual void calArea()
        {
            Console.WriteLine("Heloo form shape class");
        }
    }
    public class circle : Shape
    {
        public override void calArea()
        {
            Console.WriteLine("ENeter Radius : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of Circle = " + (3.14 * n * n));
        }
    }

    public class rectangle : Shape
    {
        public override void calArea()
        {
            Console.WriteLine("ENter length");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENter breadth : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of Rectangle = " + (l * b));
        }
    }
}
