using System;
using static System.Console;
using System.IO;

namespace Lab10_1A
{
    class Account
    {
        protected double balance;
        protected string name;
        protected int accountNum;

        public void setValues(string n, double b, int an)
        {
            balance = b;
            name = n;
            accountNum = an;
        }

        public void withdraw(double amount)
        {
            if ((balance - amount) >= 0)
            {
                balance-=amount;
                WriteLine("Amount Withdrawn: " + amount);
                WriteLine("Current Balance: " + balance);
            }
            else
            {
                WriteLine("Insufficient funds for withdrawal");
            }
        }

        public void deposit(double amount)
        {
            balance+=amount;
            WriteLine("Amount Deposited: " + amount);
            WriteLine("Current Balance: " + balance);
        }

        public virtual void addInterest()
        {
            balance = balance * 1.035;

            WriteLine("3.5% interest was added");
            WriteLine("New Balacne: " + balance);
        }

        public virtual void printData()
        {
            WriteLine("Balance: " + balance + ", Name: " + name + ", Account Number: " + accountNum);
        }
    }
}
