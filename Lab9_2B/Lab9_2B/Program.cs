using System;
using static System.Console;
using System.IO;

namespace Lab9_2B
{
    /*
     * Adam Gaddis
     * Uses the student class to input values from a text file, and compare averages
     * */
    class Program
    {
        static void Main(string[] args)
        {
            FileStream infile = new FileStream("Lab9_2B.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader reader = new StreamReader(infile);
            string fName, lName, m;
            double t1, t2, t3, avg;
            
            string recordln = reader.ReadLine();
            string[] fields;
            fields = recordln.Split(',');
            fName = fields[0];
            lName = fields[1];
            m = fields[2];
            t1 = double.Parse(fields[3]);
            t2 = double.Parse(fields[4]);
            t3 = double.Parse(fields[5]);

            Student student1 = new Student(fName, lName, m, t1, t2, t3);
            student1.computeAvg();
            WriteLine();


            recordln = reader.ReadLine();
            fields = recordln.Split(',');
            fName = fields[0];
            lName = fields[1];
            m = fields[2];
            t1 = double.Parse(fields[3]);
            t2 = double.Parse(fields[4]);
            t3 = double.Parse(fields[5]);

            Student student2 = new Student(fName, lName, m, t1, t2, t3);
            student2.computeAvg();
            WriteLine();

            recordln = reader.ReadLine();
            fields = recordln.Split(',');
            fName = fields[0];
            lName = fields[1];
            m = fields[2];
            t1 = double.Parse(fields[3]);
            t2 = double.Parse(fields[4]);
            t3 = double.Parse(fields[5]);

            Student student3 = new Student(fName, lName, m, t1, t2, t3);
            student3.computeAvg();
            WriteLine();

            Student student4 = new Student("Mary", "Latham", "Math");
            student4.setTest(85,88,92);
            student4.computeAvg();

            

            
            if (student2 < student4)
            {
                WriteLine("Student 2's average is lower than student 4's.");
            }
            else
            {
                WriteLine("Student 2's average is higher than student 4's.");
            }
        }
    }
}
