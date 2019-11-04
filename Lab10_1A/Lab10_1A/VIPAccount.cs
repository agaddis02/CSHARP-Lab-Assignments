using System;
using static System.Console;
using System.IO;

namespace Lab10_1A
{
    class VIPAccount : Account
    {
        new public void addInterest()
        {
            balance = balance * 1.05;

            WriteLine("5% interest was added");
            WriteLine("New Balacne: " + balance);
        }

        new public void printData()
        {
            WriteLine("This is a VIP Account");
            WriteLine("Balance: " + balance + ", Name: " + name + ", Account Number: " + accountNum);
        }
    }
}
