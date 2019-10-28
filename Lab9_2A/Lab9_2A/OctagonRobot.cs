using System;
using static System.Console;
using System.IO;

namespace Lab9_2A
{
    class OctagonRobot
    {
        /*
         * Adam Gaddis
         * Cals the P and A of a octagon
         * */
        private double sideLength, area, perimeter;


        public OctagonRobot()
        {
            sideLength = 20;

        }

        public OctagonRobot(double sl)
        {
            sideLength = sl;
        }

        public void printAnswers()
        {
            WriteLine("The side lenght is: " + sideLength.ToString("F2"));
            WriteLine("The perimeter is: " + perimeter.ToString("F2"));
            WriteLine("The area is: " + area.ToString("F2"));
        }

        public void calcAnswer()
        {
            perimeter = 8 * sideLength;

            double ppart = 1 + Math.Sqrt(2);
            double squared = 2 * Math.Pow(sideLength, 2);

            area = squared * ppart;

            printAnswers();
        }
    }
}
