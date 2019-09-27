using System;
using System.IO;
using static System.Console;

namespace Lab14_1B
{
    /*
     * Adam Gaddis
     * This is program ask a user for the number between one through ten, then outputs the multiplication table
     * */
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances to Write to a file
            FileStream outfile = new FileStream("Lab14B.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outfile);

            // Decalre the varuiable
            int num;



            do
            {
                // Store Value
                Write("Enter a number between 1 and 10: ");
                num = Convert.ToInt32(ReadLine());
            // If the user enters a number that is great than 10 or les than one make the user enter a number again
            } while (num < 1 || num > 10);

            // As long as i is less than or equal to 10 multiple the users number by i 
            for (int i = 1; i <= 10; i++)
                {

                    writer.WriteLine("" + num + " X " + i + " = " + num * i);
                }
            





            writer.Close();
            outfile.Close();
        }
    }
}
