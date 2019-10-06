using System;
using System.IO;
using static System.Array;
using static System.Console;


namespace Lab6_1A
{
    /*
     * Adam Gaddis
     * this program will find the last negative integer inside of the array 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            int[] numbers = new int[10];
            int negNum = 1;

            // check to see fi file exist
            if (File.Exists("lab6_1A.txt"))
            {
                // create our reader
                FileStream infile = new FileStream("lab6_1A.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(infile);

                // read in all values from the txt file to be a new index in our array
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(reader.ReadLine());
                    //if one of the values is negaive, change the value of 1neg
                    if (numbers[i] < 0)
                        negNum = numbers[i];
                }



                // Print back to user
                WriteLine("Last Negative Number: " + negNum);
                reader.Close();
                infile.Close();

            }

            else
                WriteLine("File does not exist");
        }
    }
}
