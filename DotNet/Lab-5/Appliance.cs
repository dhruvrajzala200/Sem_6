using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    public abstract class Appliance
    {
        public abstract void TurnOn();
        
    }
    public  class Fan : Appliance 
    {
        public override void TurnOn()
        {
            Console.WriteLine("Hello from Fan");
        }
    }
    public  class Light : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Hello from Light");
        }
    }

}
