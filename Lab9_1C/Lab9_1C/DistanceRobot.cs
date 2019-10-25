using System;
using static System.Console;
using static System.Array;
using System.IO;

namespace Lab9_1C
{
    /*
     * Adam Gaddis
     * Calulates distance using points
     * */
    class DistanceRobot
    {
        private double x1, y1, x2, y2, distance;

        public void setInstance(double n1, double n2, double n3, double n4)
        {
            x1 = n1;
            y1 = n2;
            x2 = n3;
            y2 = n4;

        }

        private void printDist()
        {
            WriteLine("Distance is: " + distance);
        }

        public void callDist()
        {
            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            printDist();
        }
    }
}
