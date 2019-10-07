using System;
using static System.Console;
using System.IO;
using static System.Array;
using System.Linq;

namespace Lab6_2C
{
    /*
     * Adam Gaddis
     * The program finds the amount of odd numbers within a 2d array of integers
     * */
    class Program
    {
        static void Main(string[] args)
        {

            if (File.Exists("Lab6_2C.txt"))
            {
                // Constants 
                const char DELIM = ',';

                // Declare Variables
                int[,] numbers = new int[10, 10];
                int odd = 0, even = 0;
                string line;
                string[] fields;

                // Create our reader 
                FileStream infile = new FileStream("Lab6_2C.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(infile);

                for (int i = 0; i < 10; i++)
                {
                    line = reader.ReadLine();
                    fields = line.Split(DELIM);
                    for (int j = 0; j < 10; j++)
                    {
                        numbers[i, j] = int.Parse(fields[j]);
                        if (int.Parse(fields[j]) % 2 != 0)
                        {
                            odd++;
                        }
                        else
                        {
                            even++;
                        }
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    int j = 0;
                    Write("\n");
                    for (j = 0; j < 10; j++)
                    {
                        Write(numbers[i, j]);
                        Write(" ");
                    }
                }

                WriteLine();
                WriteLine("\nOdd Numbers: " + odd);
                WriteLine("Even Numbers: " + even);

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
