using System;
using static System.Console;

namespace Lab2_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Adam Gaddis
             * This program uses formatting in printigng to print out a given table
             * 
             * */

            WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\/////////////////////////////////");
            WriteLine("{0,-8}{1,33}{2,25}", "==", "Student Points", "==");
            WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\/////////////////////////////////");
            WriteLine("{0,-8}{1,20}{2,18}{3,19}", "Name", "Lab", "Bonus", "Total");
            WriteLine("{0,-8}{1,20}{2,18}{3,19}", "_______", "__", "___", "___");
            WriteLine("{0,-8}{1,20}{2,18}{3,19}", "\"Joe\"", "43", "7", "50");
            WriteLine("{0,-8}{1,19}{2,18}{3,19}", "\"William\"", "50", "8", "58");
            WriteLine("{0,-8}{1,18}{2,18}{3,19}", "\"Mary Sue\"", "39", "10", "49");
            WriteLine("{0,-8}{1,20}{2,18}{3,19}", "\"Adam\"", "70", "10", "80");
            WriteLine("{0,-8}{1,20}{2,18}{3,19}", "\"Karen\"", "150", "50", "200");

        }

    }
}
