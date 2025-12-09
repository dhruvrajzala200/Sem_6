using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    public abstract class Payment
    {
        public abstract void MakePayment(int Amount);
    }

    public class CreditCardPayment : Payment
    {
        public override void MakePayment(int Amount)
        {
            Console.WriteLine("Payment is Credit");
        }
    }
    public class UPIPayment : Payment
    {
        public override void MakePayment(int Amount)
        {
            Console.WriteLine("Payment is done by Upi");
        }
    }
}
