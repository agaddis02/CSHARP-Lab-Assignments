using System;
using static System.Console;
using static System.Array;
using System.IO;

namespace Lab8_1B
{
    /*
     * Adam Gaddis
     * This program calculates the volume of a sphere, cube, or cylinder using an overloaded method 
     */

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Volume Calculator");
            WriteLine("Input a S for sphere, C for cylinder, and B for box");
            char choice = char.Parse(ReadLine());

            if (choice == 'S')
            {
                WriteLine("Enter Radius");
                double radius = double.Parse(ReadLine());
                WriteLine("The Volume is: " + calcVolume(radius));
            }
            else if (choice == 'C')
            {
                WriteLine("Enter Radius, and height");
                double radius = double.Parse(ReadLine());
                double height = double.Parse(ReadLine());
                WriteLine("The Volume is: " + calcVolume(radius, height));
            }
           else  if (choice == 'B')
            {
                WriteLine("Enter Length, Width, and height");
                double length = double.Parse(ReadLine());
                double width = double.Parse(ReadLine());
                double height = double.Parse(ReadLine());
                WriteLine("The Volume is: " + calcVolume(length, width, height));
            }

        }


        // Sphere
        static double calcVolume(double r)
        {
            double volume = 1.333333333333333 * Math.PI * Math.Pow(r, 3);
            return volume;
        }

        // Cylinder
        static double calcVolume(double r, double h)
        { 
            double volume = Math.PI * Math.Pow(r,2) * h;
            return volume;
        }

        // Box
        static double calcVolume(double l, double w, double h)
        {
            double volume = l * w * h;
            return volume;
        }
    }
}
