using System;
using static System.Console;

namespace Lab5_2C
{
    class Program
    {
        static void Main(string[] args)
        {
                


            
            // Declare Variables
            int num = 1;

            while (num != 0) 
            {
                    int count = 0;


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
                        // if the number is divisiable by the checker, its not prime, increase counter
                        if (num % i == 0)
                        {
                                count++;
                        }

                    }

                    // Check count, if count was increased beyond zero then it was not prime
                    if(count > 0)
                        {
                            WriteLine(num + " is not prime a prime number");
                        }
                    // else it is prime
                    else
                        {
                            WriteLine(num + " is a prime number");
                        }
                }
            } 
            







        }
    }
}
