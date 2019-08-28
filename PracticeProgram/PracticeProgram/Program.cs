using System;
using static System.Console;

namespace PracticeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            WriteLine("Enter x");
            x = Convert.ToInt32(ReadLine());
            y = 5;
            z = x * y - 20;
            WriteLine("Z is " + z);
            
        }
    }
}
