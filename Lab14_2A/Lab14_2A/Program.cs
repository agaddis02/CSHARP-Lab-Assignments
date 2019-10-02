using System;
using static System.Console;
using System.IO;

namespace Lab14_2A
{
    class Program
    {
        /*
         * Adam Gaddis
         * This program is the same as Lab14_1C, but outputs to another file
         * */
        static void Main(string[] args)
        {

            // Declare a constant
            const char DELIM = ',';

            // Declare variables
            // Doubles
            double average, sum, grade1, grade2, grade3, grade4, grade5;
            // Strings
            string recordln, lastName, firstName, major;
            // Array of Strings
            string[] fields;




            // read in our file
            FileStream infile = new FileStream("Lab142A.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);

            // Our output file
            FileStream outfile = new FileStream("Lab142A_Out.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outfile);

            // set recordln to the next line of reader
            recordln = reader.ReadLine();

            // as long as recordln has an item, continue the loop
            while (recordln != null)
            {
                // set the array fieds = to the value of readLine, excluding any semi colons
                fields = recordln.Split(DELIM);

                // set variables equal to the appropriate index of fields
                lastName = fields[0];
                firstName = fields[1];
                major = fields[2];
                grade1 = Convert.ToDouble(fields[3]);
                grade2 = Convert.ToDouble(fields[4]);
                grade3 = Convert.ToDouble(fields[5]);
                grade4 = Convert.ToDouble(fields[6]);
                grade5 = Convert.ToDouble(fields[7]);

                // math to calculate average
                sum = grade1 + grade2 + grade3 + grade4 + grade5;
                average = sum / 5;
                // Write line the proper format with grades
                writer.WriteLine(firstName + DELIM + lastName + DELIM + major + DELIM + average + DELIM);

                // continue to read
                recordln = reader.ReadLine();


            }

            // close all readers or writers
            reader.Close();
            infile.Close();
            writer.Close();
            outfile.Close();

        }
    }
}
