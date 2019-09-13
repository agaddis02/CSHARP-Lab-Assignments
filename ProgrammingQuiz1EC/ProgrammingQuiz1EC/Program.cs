using System;
using static System.Console;

namespace ProgrammingQuiz1EC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double item1, item2, item3, subTotal, salesTax, totalCost, amountPaid, changeDue;

            // Prompt user and store values
            WriteLine("Enter 3 currency amounts that are less than $5.00");
            item1 = Convert.ToDouble(ReadLine());
            item2 = Convert.ToDouble(ReadLine());
            item3 = Convert.ToDouble(ReadLine());

            // calculations
            subTotal = item1 + item2 + item3;

            salesTax = (subTotal * 0.0825);

            totalCost = subTotal + salesTax;

            amountPaid = 20;

            changeDue = amountPaid - totalCost;
            
            // Print out 
            WriteLine("The Sub Total was: " + subTotal.ToString("C"));
            WriteLine("The Sales Tax was: " + salesTax.ToString("C"));
            WriteLine("The Total Amount was: " + totalCost.ToString("C"));
            WriteLine("You Paid: " + amountPaid.ToString("C"));
            WriteLine("Your Change is: " + changeDue.ToString("C"));

        }
    }
}
