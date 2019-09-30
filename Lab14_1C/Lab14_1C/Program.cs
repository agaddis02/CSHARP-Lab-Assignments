using System;
using System.IO;
using Microsoft.VisualBasic;
using static System.Console;

namespace Lab14_1C
{
    /*
     * Adam Gaddis
     * This program reads in a csv with student grades, and calculates the average of the grades
     * */
    class Program
    {
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
            FileStream infile = new FileStream("Lab14C.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);

            // set recordln to the next line of reader
            recordln = reader.ReadLine();
            // format heading
            WriteLine("{0,-20}{1,-10}{2,10}{3,20}", "firstName", "lastName", "major", "average");
            WriteLine("{0,-20}{1,-10}{2,10}{3,20}", "---------", "--------", "-----", "-------");
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
                WriteLine("{0,-20}{1,-10}{2,10}{3,20}", firstName, lastName, major, average);

                // continue to read
                recordln = reader.ReadLine();
                

            }

          
        }
    }
}
