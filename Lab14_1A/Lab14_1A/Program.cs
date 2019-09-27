using System;
using static System.Console;
using System.IO;

namespace Lab14_1A
{
    /*
     * Adam Gaddis
     * this program checks a .txt file, and does a factorial for each line within the .txt file
     * */

    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration
            int i, fact = 1, number;


            // Only run code if we find the file
            if (File.Exists("Lab14A.txt"))
            {
                // Create the file and add to file reader
                FileStream infile = new FileStream("Lab14A.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(infile);


                for (i = 1; i <= 5; i++)
                {
                    number = Convert.ToInt32(reader.ReadLine());
                    fact = 1;
                    for(int j = 1; j <= number; j++)
                    {
                        fact = fact * j;
                    }
                    WriteLine("the factorial of " + number + "is: " + fact);
                }


                // Close File Stream and Stream Reader
                reader.Close();
                infile.Close();

            }
            else
            {
                WriteLine("File was not found");
            }





        }
    }
}
