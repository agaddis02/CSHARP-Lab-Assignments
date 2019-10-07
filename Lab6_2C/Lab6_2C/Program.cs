using System;
using static System.Console;
using System.IO;
using static System.Array;
using System.Linq;

namespace Lab6_2C
{
    class Program
    {
        static void Main(string[] args)
        {

            if (File.Exists("Lab6_2C.txt"))
            {
                // Constants 
                const int ROWS = 10;
                const int COLUMNS = 10;
                const char DELIM = ',';

                // Declare Variables
                int[,] numbers = new int[ROWS, COLUMNS];
                string line;
                string[] nums = new string[100];

                // Create our reader 
                FileStream infile = new FileStream("Lab6_2C.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(infile);

                line = reader.ReadLine();

                while (line!= null)
                {
                    nums = line.Split(DELIM);
                    line = reader.ReadLine();
                }

                int rows = nums.Count();

                int columns = nums[0].Split(new char[] { DELIM },
                                          StringSplitOptions.RemoveEmptyEntries).Count();

                for (int rowCounter = 0; rowCounter < rows; rowCounter++)
                {
                    string[] record = nums[rowCounter].Split(DELIM);
                    for (int columnCounter = 0; columnCounter < columns; columnCounter++)
                    {
                        numbers[rowCounter, columnCounter] = int.Parse(record[columnCounter]);
                    }

                }
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j =0; j < numbers.Length; j++)
                    {
                        WriteLine(numbers[i,j]);
                    }
                }
            }
            else
            {
                WriteLine("File does not exist");
            }

            /*
            line = reader.ReadLine();

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {

                    numbers[i, j] = line.Split(DELIM);
                    reader.ReadLine();
                    WriteLine(numbers[i, j]);
                }
            }
            */









        }
    }
}
