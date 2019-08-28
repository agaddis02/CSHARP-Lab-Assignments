using System;
using System.Text;
using static System.Console;

namespace Lab1_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Double area, circumference;
            Double radius;
            string str_radius;

            WriteLine("Enter radius");
            str_radius = ReadLine();
            radius = Convert.ToInt32(str_radius);

            area = 3.14 * radius * radius;
            circumference = 3.14 * 2 * radius;

            WriteLine("Area: " + area);
            WriteLine("Circumference: " + circumference);


        }
    }
}
