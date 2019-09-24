using System;

namespace Lab5_2C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            int num =-1, checker;




            while (num != 0)
            {

                // Prompt user and store value
                Console.WriteLine("Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());



                // as long as the number divided by 2 doesnt equal 1 or zero run code
                for (checker = 2; checker <= num / 2; checker++)
                 {
                    // if the number is divisiablel by the checker, its not prime
                    if (num % checker == 0)
                     {
                        Console.WriteLine(num + " is not prime number");
                    }

                }
                Console.WriteLine(num + " is a prime number");

            }
        }
    }
}
