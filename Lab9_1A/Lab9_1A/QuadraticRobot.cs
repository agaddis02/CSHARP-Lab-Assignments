using System;
using static System.Console;
using static System.Array;
using System.IO;


namespace Lab9_1A
{
    /*
     * Adam Gaddis
     * calculates quadratic equations
     * */
    class QuadraticRobot
    {
        private double a, b, c, answer1, answer2;

        public void setInstance(double n1, double n2, double n3)
        {
            a = n1;
            b = n2;
            c = n3;
        }

        private void printAnswers()
        {
            WriteLine("1st Answer: " + answer1);
            WriteLine("2nd Answer: " + answer2);
        }
        public void calcAnswers()
        {
            double sqrtpart = (b * b) - (4 * a * c);
            answer1 = ((-1) * b + Math.Sqrt(sqrtpart)) / (2 * a);
            answer2 = ((-1) * b - Math.Sqrt(sqrtpart)) / (2 * a);

            printAnswers();
        }
    }
}
