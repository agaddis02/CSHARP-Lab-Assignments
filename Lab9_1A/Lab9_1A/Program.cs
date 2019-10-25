using System;
using static System.Console;
using static System.Array;
using System.IO;


namespace Lab9_1A
{

    /* 
     * Adam Gaddis
     * Uses quad bot to calculate quad problems
     * */
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticRobot robot = new QuadraticRobot();
            double x, y, z;
            WriteLine("Enter 3 numbers: ");
            x = double.Parse(ReadLine());
            y = double.Parse(ReadLine());
            z = double.Parse(ReadLine());

            robot.setInstance(x, y, z);
            robot.calcAnswers();
        }
    }
}
