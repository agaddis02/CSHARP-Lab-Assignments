using System;
using static System.Console;
using static System.Array;
using System.IO;
using static System.Random;

namespace Lab7_2A
{
    /*
     * Adam Gaddis
     * that will count the number of words and vowels in a sentence
     * */
    class Program
    {
        static void Main(string[] args)
        {
            FileStream infile = new FileStream("Lab7_2A.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);
            string line = reader.ReadLine();
            WriteLine("Number of vowels: " + countVowels(line));
            WriteLine("Number of words: " + countWords(line));
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
        static int countVowels(string s)
        {
            int count = 0;
            for (int i =0; i < s.Length; i++)
            {
                if (isVowel(s[i]))
                {
                    count++;
                }
            }
            return count;
        }
        static int countWords(string s)
        {
            int count =0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
