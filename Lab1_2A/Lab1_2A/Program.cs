using System;
using static System.Console;

namespace Lab1_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Request amount from user and Store in variable "totalAmount"
            WriteLine("Enter an amount larger than $1");
            int totalAmount = Convert.ToInt32(ReadLine());

            // Declare Variables
            int quarters = 25;
            int dimes = 10;
            int nickels = 5;
            int pennies = 1;

            // Calculations
            int nbrQuarters = (totalAmount / quarters);
            totalAmount %= quarters;
            int nbrDimes = (totalAmount / dimes);
            totalAmount %= dimes;
            int nbrNickels = (totalAmount / nickels);
            totalAmount %= nickels;
            int nbrPennies = (totalAmount / pennies);
            totalAmount %= pennies;

            // Print Statements
            WriteLine(nbrQuarters);
            WriteLine(nbrDimes);
            WriteLine(nbrNickels);
            WriteLine(nbrPennies);

        }
    }
}
