using System;
using static System.Console;
using static System.Array;
using System.IO;
using static System.Random;

namespace Lab7_2C
{
    /*
    * Adam Gaddis
    * 
    * */
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            fillArray(arr);
            if (goingUp(arr))
            {
                WriteLine("Array is increasing");
            }
            else if (goingDown(arr))
            {
                WriteLine("Array is Decreasing");
            }
            else
            {
                WriteLine("Array is neither increasing or decreasing");
            }

        }

        static void fillArray(int[] arr)
        {
            FileStream infile = new FileStream("Lab7_2C1.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);

            string line = reader.ReadLine();


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(line);
            }
        }

        static bool goingDown(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;

        }
        static bool goingUp(int[] arr)
        {

            for (int i = 0; i < arr.Length -1; i++)
            {

                if (arr[i] < arr[i + 1])
                {
                    return false;
                }

            }
            return true;
        }
    }
}
