using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    public class Bike : IRentable
    {
        public string Brand { get; set; }
        public double RentPerDay { get; set; }

        public Bike(string brand, double rentPerDay)
        {
            Brand = brand;
            RentPerDay = rentPerDay;
        }

        public double CalculateRent(int days)
        {
            return days * RentPerDay;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Bike Brand: {Brand}, Rent/Day: {RentPerDay}");
        }
    }
}
