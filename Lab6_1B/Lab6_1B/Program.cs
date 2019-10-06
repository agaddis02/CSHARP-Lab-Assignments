using System;
using static System.Array;
using static System.Console;

namespace Lab6_1B
{
    /*
     * Adam Gaddis
     * This program creates an array of 15, each index being 2* the previous, and also sums the values
     * */
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int[] numbers = new int[15];
            int sum = 0;
            // loop as long as i is less than the length of our array
            for (int i = 0; i < numbers.Length; i++)
            {
                // multiple the current index by 2 to equal our new value
                numbers[i] = i * 2;
                // Write on the same line with a space
                Write(numbers[i] + " ");
                // Increase our sum by the value of the curren index
                sum += numbers[i];
            }
            // Write out the sum
            WriteLine("\nSum: " + sum + "\n");
        }
    }
}
