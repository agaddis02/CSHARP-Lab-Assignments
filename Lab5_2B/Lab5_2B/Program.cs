using System;
using static System.Console;

namespace Lab5_2B
{
    /*
     * Adam Gaddis 
     * This program has the user enter a number, then checks if the number entered is prime or not
     * */
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            int num;

            // Prompt user and store value
            WriteLine("Enter a number: ");
            num = Convert.ToInt32(ReadLine());

            // 0 and 1 cant be prime
            if (num == 0 || num == 1)
            {
                WriteLine(num + " is not prime number");
            }

            else
            {
                // as long as the number divided by 2 doesnt equal 1 or zero run code
                for (int i = 2; i <= num / 2; i++)
                {
                    // if the number is divisiablel by the checker, its not prime
                    if (num % i == 0)
                    {
                        WriteLine(num + " is not prime number");
                        return;
                    }

                }
                WriteLine(num + " is a prime number");
            }
        }
    }
}
