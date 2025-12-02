using ConsoleApp2;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student stud1 = new Student();
            //Student stud2 = new Student();

            //stud1.name = "Zala";
            //stud1.rollNo = 609;
            //stud1.marks = 7;

            //stud2.name = "Dhruvrajsinh";
            //stud2.rollNo = 610;
            //stud2.marks = 8;

            //stud1.display();
            //stud2.display();

            //Rectangle rec = new Rectangle(15, 25);
            //double result = rec.GetArea();
            //Console.WriteLine("Arear of Rec = "+result);


            //Console.WriteLine("ENter number 1 : ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("ENter number 2 : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            ////double res = num1 / num2;
            //try
            //{
            //    Console.WriteLine("Div = " +(num1/num2));
            //}
            //catch(DivideByZeroException d)
            //{ 
            //    Console.WriteLine(d.Message);
            //}

            //BankAcc account = new BankAcc(362834, "Zala", 9999);
            //account.withdrawl(9999);
            //Console.WriteLine("Balance = " + account.getbalance());
            //account.withdrawl(2500);
            //account.deposite(5000);
            //Console.WriteLine("Balance = "+account.getbalance());

            //Person p1 = new Person();
            //Person p2 = new Person("Zaala");
            //Person p3 = new Person("Dhruvrajsinh",20);
            //Person p4 = new Person("Varun", 18, 611);

            //p1.display();
            //p2.display();
            //p3.display();
            //p4.display();

            Employee e1 = new Employee(103,"ddddd",5000);
            e1.display();
        }
    }
}
