using System;
using static System.Console;
namespace Lab4_1A
{
    class Program
    {
        static void Main(string[] args)

            /* 
             * Adam Gaddis 
             * This program ask the user foir 3 sides of the triangle, and tells the user if it is a right triagnle or not.
             * */
        {
            // Create Variables
            double sideA, sideB, sideC;

            // Prompt user 
            WriteLine("what are the 3 side lenths of your triangle");

            // Store values 
            sideA = Convert.ToDouble(ReadLine());
            sideB = Convert.ToDouble(ReadLine());
            sideC = Convert.ToDouble(ReadLine());

            bool rightTriangleA = Math.Pow(sideA, 2) == (Math.Pow(sideB, 2) + Math.Pow(sideC, 2));
            bool rightTriangleB = Math.Pow(sideB, 2) == (Math.Pow(sideA, 2) + Math.Pow(sideC, 2));
            bool rightTriangleC = Math.Pow(sideC, 2) == (Math.Pow(sideB, 2) + Math.Pow(sideA, 2));
            // if logic
            if ( rightTriangleA || rightTriangleB || rightTriangleC)
            {
                WriteLine("this is a right triangle");
            }
            else
            {
                WriteLine("This is not a right triangle");
            }

        }
    }
}
