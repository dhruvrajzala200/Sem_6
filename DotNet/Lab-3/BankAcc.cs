using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class BankAcc
    {
        public int accNum;
        public string holderName;
        public int balance;

        public BankAcc(int accNum, string holderName, int balance)
        {
            this.accNum = accNum;
            this.holderName = holderName;
            this.balance = balance;
        }

        public void deposite(int value)
        {
            balance += value;
        }

        public void withdrawl(int value)
        {
            if (balance < value)
            {
                Console.WriteLine("Khatama paisa j nathi!!");
            }
            else
            {
                balance -= value;
            }
        }
        public int getbalance() { return balance; }
    }
}
