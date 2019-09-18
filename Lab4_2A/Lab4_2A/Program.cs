using System;
using static System.Console;


namespace Lab4_2A
{

    /*
     * Adam Gaddis
     * This program acts as the magic 8ball, and gives a random answer to a yes or no question.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new System.Random();

            string response;
            int value;

            // Prompt the user
            WriteLine("Magic 8 Ball");
            WriteLine("Enter a yes or no question");
            // Wait for users input
            ReadLine();

            WriteLine(" *Shake* *Shake* ");


            // Random Generation
            value = random.Next(0, 10) + 1;

            // Switch statement for differenct values
            switch (value)
            { 
                case 1:
                    WriteLine("Not today");
                    break;
                case 2:
                    WriteLine("The signs are positive");
                    break;
                case 3:
                    WriteLine("Definetly!");
                    break;
                case 4:
                    WriteLine("Never");
                    break;
                case 5:
                    WriteLine("Maybe");
                    break;
                case 6:
                    WriteLine("It's not in the stars");
                    break;
                case 7:
                    WriteLine("Ask again later");
                    break;
                case 8:
                    WriteLine("Possibly so");
                    break;
                case 9:
                    WriteLine("Looks good");
                    break;
                case 10:
                    WriteLine("There's no telling");
                    break;

            }
            


            
        }
    }
}
