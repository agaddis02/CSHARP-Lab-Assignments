using System;
using static System.Console;
using System.IO;

namespace Lab9_2A
{
    /*
     * Adam Gaddis
     * This program returns the values of a octagon from the bot 
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            double sl;

            WriteLine("Enter the side length of an octagon: ");
            sl = double.Parse(ReadLine());

            OctagonRobot bot = new OctagonRobot(sl);
            WriteLine("Bot 1: ");
            bot.calcAnswer();
            OctagonRobot bot2 = new OctagonRobot();
            WriteLine("Bot 2");
            bot2.calcAnswer();
        }
    }
}
