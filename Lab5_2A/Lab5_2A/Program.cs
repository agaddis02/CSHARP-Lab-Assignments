using System;
using static System.Console;

namespace Lab5_2A
{
    /* 
 * Adam Gaddis
 * This program takes a number from the user, and prints out all of the divsors for the number
 * */
    class Program
    {
        static void Main(string[] args)
        {

            // Declare variables
            int num;

            // Prompt user and store value
            WriteLine("Enter a Number: ");
            num = Convert.ToInt32(ReadLine());

            // Print list of divisots
            WriteLine("The Factors of " + num + " are : ");

            // for as long as checker is less than or equal to the inputted number continue running
            for (int i = 1; i<= num; i++)
            {
                // if the number divided by the checker has a remainder of zero, its a divisor
                if (num % i == 0)
                {
                    WriteLine(i);
                }
            }


        }
    }
}
