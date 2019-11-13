using System;
using static System.Console;
using System.IO;

namespace Lab11_1B
{
    class Program
    {
        /*
         * This program loops through a text file, determines the size
         * */
        static void Main(string[] args)
        {
            Monsters[] monsters = new Monsters[10];

            string type = "";
            int size = 0;

            FileStream infile = new FileStream("Lab11_1B.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);

            string[] fields;
            string line;
            try
            {
                line = reader.ReadLine();


                // set array fields equal to the file split

                while (line != null)
                {
                    for (int i = 0; i < monsters.Length; i++)
                    {
                        fields = line.Split(',');
                        type = fields[0];
                        try
                        {
                            size = int.Parse(fields[1]);
                        }
                        catch
                        {
                            size = 0;
                        }
                        monsters[i] = new Monsters(type, size);
                        line = reader.ReadLine();

                    }

                }

                WriteLine();
                findSmallest(monsters);
                averageSize(monsters);
            }
            catch (Exception e)
            {

                e.ToString();
            }



        }
        public static void findSmallest(Monsters[] monsters)
        {
            int setsize = 99909;
            int currentSize;
            string mont = "";

            for (int i = 0; i < monsters.Length; i++)
            {
                currentSize = monsters[i].getSize();

                if ( currentSize < setsize)
                {
                    setsize = monsters[i].getSize();
                    mont = monsters[i].getType();

                }
            }
            WriteLine("Smallest Monster");
            WriteLine("Type: " + mont);
            WriteLine("Size: " + setsize);



        }

        public static void averageSize(Monsters[] monsters)
        {
            int total = 0, count;
            double avg;
            for (int i = 0; i < monsters.Length; i++)
            {

                int currentSize = monsters[i].getSize();

                total += currentSize;


            }
            count = monsters.Length;
            avg = total / count;

            WriteLine("Average Size: " + avg);


        }
    }
}
