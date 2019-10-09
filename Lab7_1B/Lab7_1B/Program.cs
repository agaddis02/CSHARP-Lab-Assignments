using System;
using static System.Console;
using System.IO;

namespace Lab7_1B
{
    /*
     * Adam Gaddis
     * This program reads the file and returns the GCD of the pair of numbers 
     * */
    class Program
    {



        static void Main(string[] args)
        {
            // array for inputs
            int num1, num2;
            string[] fields;
            string line;

            // create rader object
            FileStream infile = new FileStream("Lab7_1B.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);

            line = reader.ReadLine();

            while (line != null)
            {
                // set array fields equal to the file split
                fields = line.Split(',');
                num1 = int.Parse(fields[0]);
                num2 = int.Parse(fields[1]);
                WriteLine("The GCD of " + num1 + " and " + num2 + " is: " + getDenominator(num1, num2));
                line = reader.ReadLine();
            }


        }

        public static int getDenominator(int num1, int num2)
        {
            while (num1 != num2)

            {

                if (num1 > num2)

                    num1 = num1 - num2;



                if (num2 > num1)

                    num2 = num2 - num1;

            }

            return num1;
        }


    }
}
