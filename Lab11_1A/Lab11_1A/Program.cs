using System;
using static System.Console;
using System.IO;

namespace Lab11_1A
{
    class Program
    {
        /*
        *Adam Gaddis
        * This code gets the average of an array that is read in, and catches anyt error and displays the error message
        */
        static void Main(string[] args)
        {
            double average, total = 0;
            int i = 0;
            int[] Array = new int[10];

            FileStream infile = new FileStream("Lab11_1A.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);

            try
            {
                for (i = 0; i < 10; i++)
                {

                    Array[i] = Convert.ToInt32(reader.ReadLine());
                    Write(Array[i] + " ");
                    total += Array[i];
                }
                Array[10] = 5;

                average = total / 10;
                WriteLine("\nAverage: {0}", average);

            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }

            finally
            {
                infile.Close();
            }
        }


    }
}
