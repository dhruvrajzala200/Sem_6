namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calc calc = new Calc();
            //calc.add(2, 3);
            //calc.add(4, 5, 6);
            //calc.add(5.6, 2.6);

            //Employee emp = new Employee();
            //emp.display("Zala");
            //emp.display("Dhruraj",69);
            //emp.display("Bapu",80,500000);

            //Person per = new Person();
            //Console.WriteLine("Public and internal from diff class: " + per.name + " " + per.spi);
            //per.display();

            //Console.WriteLine("Enter choice : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Animal animal = new Animal();

            //switch (n) { 
            //    case 0: 
            //        break;
            //    case 1:
            //        animal = new Dog();
            //        break;
            //    case 2:
            //        animal = new Cat();
            //        break;
            //}
            //animal.sound();

            //Shape shape = new Shape();
            //Rectangle rec = new Rectangle();
            //Circle crc = new Circle();
            //Triangle tri = new Triangle();

            //shape.calculateArea();
            //Console.WriteLine();

            //rec.calculateArea();
            //Console.WriteLine();

            //crc.calculateArea();
            //Console.WriteLine();

            //tri.calculateArea();



            BankAccount acc1 = new BankAccount("Dhruv", 5000);
            BankAccount acc2 = new BankAccount("Raj", 2000);

            BankTransaction bt = new BankTransaction();
            bt.Transfer(acc1, acc2, 1000);
            bt.Transfer(acc1, acc2, 500, "For snacks payment");

            Console.WriteLine("\nFinal Balances:");
            Console.WriteLine($"{acc1.AccountHolder}: ₹{acc1.Balance}");
            Console.WriteLine($"{acc2.AccountHolder}: ₹{acc2.Balance}");
        }
    }
}
