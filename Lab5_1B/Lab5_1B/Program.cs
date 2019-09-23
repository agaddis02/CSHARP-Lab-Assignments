using System;
using static System.Console;

namespace Lab5_1B
{

    /*
     * Adam Gaddis
     * This program prompts the user to input 5 integeres, and returns the total of the integers, and returns the average of the numbers
     * */
    class Program
    {
        static void Main(string[] args)
        {
            // Declare/ Initalize variables
            int count = 1;
            double total = 0, average = 0, num;

            // While count is less than or equal to 5 prompt user for a new integer, add to total, calculate average
            while (count <= 5)
            {
                WriteLine("Enter 5 integers");
                num = Convert.ToDouble(ReadLine());
                total += num;
                average = total / 5;
                count++;

            }

            // Print out returns 
            WriteLine("The total of the numbers you entered is: " + total);
            WriteLine("The average of the numbers you entered is: " + average);


        }
    }
}
