using System;
using static System.Console;
using System.IO;
using static System.Random;

namespace Lab10_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBin currentGame = new FizzBin();

            String response;
            do
            {
                currentGame.runGame();

                WriteLine("Would you like to continue? Y or N");
                response = ReadLine();
            } while (response.Equals("Y") || response.Equals("y"));
        }
    }
}
