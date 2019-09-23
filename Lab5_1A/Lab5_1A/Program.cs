using System;
using static System.Console;


namespace Lab5_1A
{
    /*
     * Adam Gaddis
     * This program ask the user of integers until the user inputs 0, we then return the amount of odd numbers inputted to the user
     * */
    class Program
    {
        static void Main(string[] args)
        {
            // Initialze variables
            int num = -1 , ticker = 0;

            // While num is not equal to 0 keep asking user for ints
            while(num != 0)
            {
                WriteLine("Enter Integers, enter a 0 when you wannt to exit");
                num = Convert.ToInt32(ReadLine());
                // if number is odd increase ticker
                if (!(num % 2 == 0))
                {
                    
                    ticker++;
                }

            }
            // Print count off odd numbers to user
            WriteLine("The amount of odd numbers you entered is: " + ticker);




        }
    }
}
