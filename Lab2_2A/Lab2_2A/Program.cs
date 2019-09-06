using System;
using static System.Console;


/*
 * Adam Gaddis
 * This program takes a users current salary, and displays what the salary would be with a projected raise of 4%
 * */
namespace Lab2_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constant for raise percentage
            const double percentage = .04;

            // Recieve salary from user
            WriteLine("What is your salary?");
            double salary = Convert.ToDouble(ReadLine());

            // Print current salary
            WriteLine("Current Salary: " + salary.ToString("C"));
            WriteLine("\n");

            // Calculations for raise
            double raiseAmount = salary * percentage;
            salary = salary + raiseAmount;

            // Results
            WriteLine("Percentage Increase: " + percentage.ToString("P"));
            WriteLine("Raise Amount: " + raiseAmount.ToString("C"));
            WriteLine("New Salary:" + salary.ToString("C") );

        }
    }
}
