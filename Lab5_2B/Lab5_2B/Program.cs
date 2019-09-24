using System;

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
            int num, checker;

            // Prompt user and store value
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            // 0 and 1 cant be prime
            if (num == 0 || num == 1)
            {
                Console.WriteLine(num + " is not prime number");
            }

            else
            {
                // as long as the number divided by 2 doesnt equal 1 or zero run code
                for (checker = 2; checker <= num / 2; checker++)
                {
                    // if the number is divisiablel by the checker, its not prime
                    if (num % checker == 0)
                    {
                        Console.WriteLine(num + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(num + " is a prime number");
            }
        }
    }
}
