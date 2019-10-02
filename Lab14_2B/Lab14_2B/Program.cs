using System;
using static System.Console;
using System.IO;

namespace Lab14_2B
{
    class Program
    {
        /*
 * Adam Gaddis
 * This programs takes the outputed file from the program, and prints the line for the student with the highest average
 * */
        static void Main(string[] args)
        {
            // Declare a constant
            const char DELIM = ',';

            // Declare variables
            // Doubles
            double average, highest = 0;

            // Strings
            string recordln, firstName, lastName, major, hFirstName="", hLastName="", hMajor="";


            int i = 0;

            // Array
            string[] fields;

            double[] averages = new double[4];


            // read in our file
            FileStream infile = new FileStream("Lab142A_Out.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);


            // set recordln to the next line of reader
            recordln = reader.ReadLine();


            // as long as recordln has an item, continue the loop
            while (recordln != null)
            {
                // set the array fieds = to the value of readLine, excluding any semi colons
                fields = recordln.Split(DELIM);


                firstName = fields[0];
                lastName = fields[1];
                major = fields[2];
                average = Convert.ToDouble(fields[3]);

                if (average >= highest)
                {
                    highest = average;
                    hFirstName = firstName;
                    hLastName = lastName;
                    hMajor = major;
                }


                // continue to read
                recordln = reader.ReadLine();

            }

            // format heading
            WriteLine("{0,-20}{1,-10}{2,10}{3,20}", "firstName", "lastName", "major", "average");
            WriteLine("{0,-20}{1,-10}{2,10}{3,20}", "---------", "--------", "-----", "-------");
            // Write line the proper format with grades
            WriteLine("{0,-20}{1,-10}{2,10}{3,20}", hFirstName, hLastName, hMajor, highest);



            // close all readers or writers
            reader.Close();
            infile.Close();
        }
    }
}
