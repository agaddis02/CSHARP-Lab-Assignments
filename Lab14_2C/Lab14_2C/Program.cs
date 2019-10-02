using System;
using static System.Console;
using System.IO;

namespace Lab14_2C
{
    class Program
    {

        /*
         * Adam Gaddis
         * This program reads ina fiel of temperature and calculate the high, low, and average
         * */

        static void Main(string[] args)
        {


            // Declare variables
            // Doubles
            double average = 0, high = 0, low = 100, count = 0, sum =0;

            double[] temperatures = new double[100];

            string recordln;

            // Array of doubles
            string[] fields;

            // read in our file
            FileStream infile = new FileStream("Lab142C.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);

            // set recordln to the next line of reader
            recordln = reader.ReadLine();

            // as long as recordln has an item, continue the loop
            while (recordln != null)
            {
                // set the array fieds = to the value of readLine, excluding any semi colons
                fields = recordln.Split();
                double num = Convert.ToDouble(fields[0]);

                if (num > high)
                {
                    high = num;
                }
                if (num < low)
                {
                    low = num;
                }

                sum += num;
                count++;
                average = sum / count;

                // continue to read
                recordln = reader.ReadLine();
            }

            

            WriteLine("Lowest Temperature: " + low);
            WriteLine("Highest Temperature: " + high);
            WriteLine("The Average Temperature: " + (int)average);

            // close all readers or writers
            reader.Close();
            infile.Close();


        }
    }
}
