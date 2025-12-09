using lab5;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();

            //dog.bark();
            //dog.eat();

            //ElectricCar electricCar = new ElectricCar();
            //electricCar.display1();
            //electricCar.display2();
            //electricCar.display3();

            //circle circle = new circle();
            //rectangle rectangle = new rectangle();

            //circle.calArea();
            //rectangle.calArea();

            //Light light = new Light();
            //Fan fan = new Fan();

            //fan.TurnOn();
            //light.TurnOn();

            //Book b = new Book();
            //Magzine m = new Magzine();

            //b.PrintDetails();
            //m.PrintDetails();

            //Robot r = new Robot();
            //r.Move();
            //r.Sound();

            //CreditCardPayment creditCardPayment = new CreditCardPayment();
            //UPIPayment uPIPayment = new UPIPayment();
            //Console.WriteLine("Enter amnt = ");
            //int Amount = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("ENter 1 for creditCardPayment 2 for UPIPayment : ");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //if (choice == 1)
            //{
            //    try
            //    {
            //        if (Amount < 100) throw new Exception("Amount 100 karta ochhu na hovu joie");
            //        creditCardPayment.MakePayment(1000);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
            //else if (choice == 2)
            //{
            //    try
            //    {
            //        if (Amount < 100) throw new Exception("Amount 100 karta ochhu na hovu joie");
            //        uPIPayment.MakePayment(1000);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}

            //Manager manager = new Manager("Zala", 9999);
            //Developer developer = new Developer("Main Goal...", 8561);

            //double bonus1 = manager.CalculateBonus();
            //double bonus2 = developer.CalculateBonus();

            //Console.WriteLine("Bonus for manager : "+bonus1+"Bonus for develloper : "+bonus2);

            List<IRentable> rentals = new List<IRentable>();

            rentals.Add(new Care("Toyota Fortuner", 1500));
            rentals.Add(new Care("Hyundai i20", 800));
            rentals.Add(new Bike("Royal Enfield", 400));
            rentals.Add(new Bike("Honda Shine", 250));

            Console.WriteLine("Vehicle Rental Details:\n");

            foreach (IRentable item in rentals)
            {
                item.DisplayDetails();
                Console.WriteLine($"Rent for 3 days: {item.CalculateRent(3)}\n");
            }

            Console.ReadLine();

        }
    }
}