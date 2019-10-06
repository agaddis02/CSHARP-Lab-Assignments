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
            // Constants 
            const int ROWS = 10;
            const int COLUMNS = 10;
            const char DELIM = ',';

            // Declare Variables
            int[,] numbers = new int[ROWS, COLUMNS];
            string line;

            // Create our reader 
            FileStream infile = new FileStream("Lab6_2C.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);

            line = reader.ReadLine();

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; i++)
                {
                    
                    numbers[i,j] = line.Split(DELIM)
                    reader.ReadLine();
                    WriteLine(numbers[i,j]);
                }
            }

        }
    }
}
