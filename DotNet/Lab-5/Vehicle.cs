using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    public class Vehicle
    {
        public virtual void display1()
        {
            Console.WriteLine("Hello form vehcile");
        }
    }
    public class Car:Vehicle
    {
        public  void display2()
        {
            Console.WriteLine("Hello form car");
        }
    }

    public class ElectricCar : Car 
    {
        public  void display3()
        {
            Console.WriteLine("Hello form ElectricCar");
        }
    }

}
