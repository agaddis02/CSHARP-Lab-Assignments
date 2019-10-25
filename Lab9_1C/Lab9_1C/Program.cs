using System;
using static System.Console;
using static System.Array;
using System.IO;


namespace Lab9_1C
{
    /* 
     * Adam Gaddis
     * uses the dist bot to cal users distance
     * */
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            DistanceRobot robot = new DistanceRobot();

            WriteLine("Enter x1, y1, x2, y2: ");
            x1 = double.Parse(ReadLine());
            y1 = double.Parse(ReadLine());
            x2 = double.Parse(ReadLine());
            y2 = double.Parse(ReadLine());

            robot.setInstance(x1, y1, x2, y2);
            robot.callDist();
        }
    }
}
