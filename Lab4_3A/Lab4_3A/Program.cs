using System;
using static System.Console;

namespace Lab4_3A
{

    /*
     * Adam Gaddis
     * This program determines if it is okay to take the dog outside or not
     * */
    class Program
    {
        static void Main(string[] args)
        {

            // Declare variables
            int tempature;
            bool isSummer;
 

            // ask use if it is summer or not
            WriteLine("Is it summer? Y or N");
            isSummer = ReadLine().Equals("Y");


            // Random Tempature
            Random random = new System.Random();
            tempature = 100 /*random.Next(0, 71) + 40*/;

            WriteLine("Summer Status: " + isSummer);

            // Print out tempature for user
            WriteLine("The tempature ouside is: " + tempature);

            // logical if statement
            if ((!isSummer) && tempature >= 60 && tempature <= 90)
            {
                WriteLine("The dogs will go out to play");
            }
            else if (isSummer && tempature >= 60 && tempature <=100)
            {
                WriteLine("The dogs will go out to play");
            }
            else
            {
                WriteLine("The dogs will not go out to play");
            }

        }
    }
}
