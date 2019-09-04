using System;
using static System.Console;
namespace Lab2_1B
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Adam Gaddis 
             * This program ask the user for distance and time to calulate average speed
             * */


            // Request input from user for distance and time
            WriteLine("Enter the Distance");
            Double distance = Convert.ToDouble(ReadLine());

            WriteLine("Enter the Time");
            Double time = Convert.ToDouble(ReadLine());

            // Calculation for speed
            Double speed = distance / time;


            // Print out results
            WriteLine("Distance Covered: " + distance + " miles");
            WriteLine("Travel Time: " + time + " hours");
            WriteLine("Average Traveling Speed: " + speed.ToString("F3") + " miles per hour");



        }
    }
}
