namespace BankApp.Models
{
    public class BankAccount
    {
        private string accountHolder;
        private double balance;

        public BankAccount(string accountHolder, double initialBalance)
        {
            this.accountHolder = accountHolder;
            this.balance = initialBalance;
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount > Balance) return false;

            Balance -= amount;
            return true;
        }
    }
}
