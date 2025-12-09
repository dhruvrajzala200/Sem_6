using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    public class Care : IRentable
    {
        public string Model { get; set; }
        public double RentPerDay { get; set; }

        public Care(string model, double rentPerDay)
        {
            Model = model;
            RentPerDay = rentPerDay;
        }

        public double CalculateRent(int days)
        {
            return days * RentPerDay;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Car Model: {Model}, Rent/Day: {RentPerDay}");
        }
    }
}
