using System;
using static System.Console;

namespace Lab5_2C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            int num = -1, checker = 0, flag = 0;



            // User doesnt write a number = 0 continue prompting
            while (num != 0)
            {
                // Prompt and store value
                WriteLine("Enter the Number to check Prime: ");
                num = Convert.ToInt32(ReadLine());

                // Checked number
                checker = num / 2;

                // as long as i is less than our given number divided by 2, continue to loop
                for (int i = 2; i <= checker; i++)
                {
                    // if our numbe and i give us a remainder of zero it is not prime
                    if (num % i == 0)
                    {
                        WriteLine("Number is not Prime.");
                        flag = 1;
                        break;
                    }
                }
               

                // 1 and 0 will read as prime although they arent 
                if (num == 1)
                {
                    WriteLine(num + " is not a prime number");
                }
                else if(num == 0)
                {
                    WriteLine("You have now exitted the loop");
                }
                else if (flag == 0)
                {
                    WriteLine("Number is Prime.");
                }



                




            }
        }
    }
}
