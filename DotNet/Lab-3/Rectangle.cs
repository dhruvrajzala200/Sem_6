using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Rectangle
    {
        public double len;
        public double bred;

        public  Rectangle(double len,double bred)
        {
            this.len = len;
            this.bred = bred;
        }

        public double GetArea()
        {
            return this.len *  this.bred;
        }
    }
}
