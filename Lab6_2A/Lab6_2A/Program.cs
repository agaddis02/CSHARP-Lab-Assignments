using System;
using System.IO;
using static System.Array;
using static System.Console;

namespace Lab6_2A
{
    /*
     * Adam Gaddis
     * this code reads in a file, astores the values in an array, and determines if the numbers are decreasing or increasing
     * */
    class Program
    {
        static void Main(string[] args)
        {
            if(File.Exists("Lab6_2A.txt")){
                // Declare Variables
                int[] numbers = new int[20];
                int flagP = 0, flagN = 0;
                // Create our reader
                FileStream infile = new FileStream("Lab6_2A.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(infile);

                // for the length of the array read the current line into the index of the array
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = int.Parse(reader.ReadLine());


                }
                // Check to make sure each number is increasing
                for (int k = 0; k < 19; k++)
                {
                    if (numbers[k] < numbers[k+1])
                    {
                        flagP++;
                    }
                    if (numbers[k] > numbers[k + 1])
                    {
                        flagN++;
                    }
                }


                // print out all of the numbers
                for (int j = 0; j < numbers.Length; j++)
                {
                    Write(numbers[j] + " ");
                }
                // within a 20 item array, the flag should be exactly 19 each time if it is a increasing array
                if(flagP == 19)
                {
                    WriteLine("\n^^This is a increasing array^^");
                }
                // is flag is never triggered then it is decreasing
                else if (flagN == 0)
                {
                    WriteLine("\n^^This is a decreasing array^^");
                }


                reader.Close();
                infile.Close();
            }
            else
            {
                WriteLine("File does not exist");
            }




        }
    }
}
