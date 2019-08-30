using System;

namespace Lab1_2B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variable
            Double length, width, height;

            Double door = 8 * 5;
            Double window = 2 * 3;

            // Prompt user and store values
            System.Console.WriteLine("Enter length");
            length = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Enter width");
            width = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Enter height");
            height = Convert.ToDouble(System.Console.ReadLine());







            Double surfaceArea = (2 * width * height) + (2 * length * height)  - (door + (2 * window));
            Double paint = surfaceArea / 120;

            System.Console.WriteLine("The Surface Area is {0}, and the paint need is {1} Gallons", surfaceArea, paint);


        }
    }
}
