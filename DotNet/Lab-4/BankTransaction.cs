namespace BankApp.Models
{
    public class BankTransaction
    {
        public void Transfer(BankAccount from, BankAccount to, double amount)
        {
            if (from.Withdraw(amount))
            {
                to.Deposit(amount);
                Console.WriteLine("Transferred ₹{amount} from {from.AccountHolder} to {to.AccountHolder}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }
        public void Transfer(BankAccount from, BankAccount to, double amount, string description)
        {
            if (from.Withdraw(amount))
            {
                to.Deposit(amount);
                Console.WriteLine("Transferred ₹{amount} from {from.AccountHolder} to {to.AccountHolder}. Note: {description}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }
    }
}
