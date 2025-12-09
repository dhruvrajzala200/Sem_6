using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    public interface IRentable
    {
        double CalculateRent(int days);
        void DisplayDetails();
    }
}

