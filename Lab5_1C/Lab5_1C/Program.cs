using System;
using static System.Console;

namespace Lab5_1C
{

    /*
     * Adam Gaddis
     * this program plays a high and low game with the user until they guess the number right
     * */
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int randomNumber, userGuess = -1;

            // Generate random number
            Random random = new System.Random();
            randomNumber = random.Next(0,100);
            WriteLine(randomNumber);

            // boolean decider
            bool found = false ;

            // While guess is not equal to random guess have the user continue to guess
            while (!found)
            {

                // Prompt user
                WriteLine("Guess a number between o and 100, keep guessing till you get it right");
                userGuess = Convert.ToInt32(ReadLine());


                if (userGuess > randomNumber)
                {
                    WriteLine("High");
                }
                else if(userGuess < randomNumber)
                {
                    WriteLine("Low");
                }
                else if (userGuess == randomNumber)
                {
                    found = true;
                    // Statements to let user know they are correct once while loop breaks
                    WriteLine("Your correct!!");
                    WriteLine(" The random number was: " + randomNumber);
                }
            }

            


        }
    }
}
