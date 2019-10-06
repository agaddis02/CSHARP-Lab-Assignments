using System;
using System.IO;
using static System.Array;
using static System.Console;
using static System.Random;
namespace Lab6_2B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            int[] numbers = new int[20];
            int userSearch, randoNum, target, resulte;

            // create random
            Random random = new Random();

            // fill the array with random numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                randoNum = random.Next(1, 100);
                numbers[i] = randoNum;
            }

            // Prompt user for a guess and store the value
            WriteLine("What number would you like for me to search for? ");
            target = int.Parse(ReadLine());

            // Sort the array
            Array.Sort(numbers);
            Write("Sorted Array: ");
            // Print out sorted array
            for (int j = 0; j < numbers.Length; j++)
            {
                Write(numbers[j] + " ");
            }

            // store our search value inside of usersearch 
            userSearch = Array.BinarySearch(numbers, target);

            // if the value if equal or greater than 0 than the item is inside of the array, becuase that is giving us the index of the array that it is at
            if (userSearch >= 0)
            {
                WriteLine("\nThe number: " + target + " was found");
            }
            else
            {
                WriteLine("\nThe number: " + target + " was not found");
            }
            // Reverse the Array
            Array.Reverse(numbers);
            Write("Reversed Array: ");
            // Print out reversed array
            for (int k = 0; k < numbers.Length; k++)
            {
                Write(numbers[k] + " ");
            }

            WriteLine();




        }
    }
}
