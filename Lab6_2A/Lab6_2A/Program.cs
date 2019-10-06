using System;
using System.IO;
using static System.Array;
using static System.Console;

namespace Lab6_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            if(File.Exists("Lab6_2A.txt")){
                // Declare Variables
                int[] numbers = new int[20];

                // Create our reader
                FileStream infile = new FileStream("Lab6_2A.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(infile);

                // for the length of the array read the current line into the index of the array
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = int.Parse(reader.ReadLine());

                }


                // print out all of the numbers
                for (int j = 0; j < numbers.Length; j++)
                {
                    Write(numbers[j] + " ");
                }

                if(numbers[1] < numbers[numbers.Length - 1])
                {
                    WriteLine("\n^^This is a increasing array^^");
                }
                else
                {
                    WriteLine("\n^^This is a decreasing array^^");
                }

            }
            else
            {
                WriteLine("File does not exist");
            }




        }
    }
}
