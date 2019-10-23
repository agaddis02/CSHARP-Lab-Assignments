using System;
using static System.Console;
using static System.Array;
using System.IO;

namespace Lab8_1A
{
    /*
     * Adam Gaddis
     * A roll the dice game that has the user continue to try and roll an 11
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, di1, di2;
            Random random = new Random();

            while (sum != 2 && sum != 11)
            {
                rollTheDice(out di1, out di2, random);
                sum = di1 + di2;

                if (sum == 2)
                {
                    WriteLine("Snake eyes - you lose :-( ");

                }
                else if (sum == 11)
                {
                    WriteLine("You win!");
                }
                else
                {
                    WriteLine("Keep rolling");
                }

                WriteLine("Press Enter to continue rolling");
                ReadLine();
                
            }

        }

        static void rollTheDice(out int di1, out int di2, Random random)
        {
            di1 = random.Next(1, 7);
            printFace(di1);
            di2 = random.Next(1, 7);
            printFace(di2);


        }



        static void printFace(int number)
        {
            switch (number)
            {
                case 1:
                    WriteLine("******");
                    WriteLine("* 1 *");
                    WriteLine("******");
                    break;
                case 2:
                    WriteLine("******");
                    WriteLine("* 2 *");
                    WriteLine("******");
                    break;
                case 3:
                    WriteLine("******");
                    WriteLine("* 3 *");
                    WriteLine("******");
                    break;
                case 4:
                    WriteLine("******");
                    WriteLine("* 4 *");
                    WriteLine("******");
                    break;
                case 5:
                    WriteLine("******");
                    WriteLine("* 5 *");
                    WriteLine("******");
                    break;
                case 6:
                    WriteLine("******");
                    WriteLine("* 6 *");
                    WriteLine("******");
                    break;
            }
        }
    }
}



