using System;
using static System.Console;
using static System.Array;
using System.IO;
using static System.Random;

namespace Lab7_2B
{
    /*
    * Adam Gaddis
    * This code deletes all vowels from an string, and changes spaces to *
    * */
    class Program
    {
        static void Main(string[] args)
        {
            FileStream infile = new FileStream("Lab7_2B.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);
            
            for (int i =0; i< 4; i++)
            {
                string line = reader.ReadLine();
                WriteLine("Original String: " + line);
                WriteLine("encrypted String: " + encrypt(line));
                WriteLine();
            }

        }

        static bool isVowel(char c)
        {
            if (c.Equals('a') || c.Equals('e') || c.Equals('i') || c.Equals('o') || c.Equals('u'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string encrypt(string s)
        {
            string h = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (isVowel(s[i]))
                {
                    h += "";
                }
                else if(s[i] == ' ')
                {
                    h += '*';
                }
                else
                {
                    h += s[i];
                }
            }
            return h;
        }
    }
}
