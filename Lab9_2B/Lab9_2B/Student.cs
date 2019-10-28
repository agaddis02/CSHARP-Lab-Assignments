using System;
using static System.Console;
using System.IO;

namespace Lab9_2B
{
    class Student
    {
        private string firstN, lastN, major;
        private double test1, test2, test3, average;

        public Student(string FN, string LN, string m, double t1, double t2, double t3)
        {
            firstN = FN;
            lastN = LN;
            major = m;
            test1 = t1;
            test2 = t2;
            test3 = t3;
            average = 0;
        }

        public Student (string FN, string LN, string m)
        {
            firstN = FN;
            lastN = LN;
            major = m;
            test1 = 0;
            test2 = 0;
            test3 = 0;
            average = 0;
        }


        public void setTest(double t1, double t2, double t3)
        {
            test1 = t1;
            test2 = t2;
            test3 = t3;
        }

        public void printStuff()
        {
            WriteLine("First Name: " + firstN);
            WriteLine("Last Name: " + lastN);
            WriteLine("Major: " + major);
            WriteLine("Test 1: " + test1);
            WriteLine("Test 2: " + test2);
            WriteLine("Test 3: " + test3);
            WriteLine("Average: " + average);
        }

        public void computeAvg()
        {
            double sumScores = test1 + test2 + test3;
            average = sumScores / 3;
            printStuff();
        }
    }
}
