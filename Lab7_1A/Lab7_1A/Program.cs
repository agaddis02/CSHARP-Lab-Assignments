using System;
using static System.Random;
using static System.Console;

namespace Lab7_1A
{
    /*
     * Adam Gaddis
     * This rogram plays a basic game of rock, paper, scissors with the user
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int usersChoice;
            WriteLine("Enter 0 for Rock, 1 for paper, and 2 for Scissors");
            usersChoice = int.Parse(ReadLine());
            determineWinner(programChoice(), usersChoice);
        }

        public static int programChoice()
        {
            int rando;
            Random random = new Random();

            rando = random.Next(0, 2);

            return rando;
        }

        public static void determineWinner(int computer, int user)
        {
            switch (computer)
            {
                case 0:
                    WriteLine("computer: Rock");
                    break;
                case 1:
                    WriteLine("computer: Paper");
                    break;
                case 2:
                    WriteLine("computer: Scissors");
                    break;
                default:
                   WriteLine("computer: Unknown");
                    break;
            }

            switch (user)
            {
                case 0:
                    WriteLine("user: Rock");
                    break;
                case 1:
                    WriteLine("user: Paper");
                    break;
                case 2:
                    WriteLine("user: Scissors");
                    break;
                default:
                    WriteLine("user: Unknown");
                    break;
            }

            if (computer == 0 && user == 2)
            {
                // Comp wins
                WriteLine("computer beats user");
            }
            else if (computer == 0 && user == 1)
            {
                // comp loses
                WriteLine("computer losess to user");
            }
            else if (computer == 0 && user == 0)
            {
                // Tie
                WriteLine("computer ties with user");
            }
            else if (user == 0 && computer == 2)
            {
                // User wins
                WriteLine("computer losess to user");
            }
            else if (user == 0 && computer == 1)
            {
                // User loses
                WriteLine("computer beats user");
            }
            else if (user == 0 && computer == 0)
            {
                // Tie
                WriteLine("computer ties with user");
            }
            else if (user == 1 && computer == 1)
            {
                // Tie
                WriteLine("computer ties with user");
            }
            else if (user == 2 && computer == 2)
            {
                // Tie
                WriteLine("computer ties with user");
            }
            else if (user == 1 && computer == 2)
            {
                // computer wins
                WriteLine("computer beats user");
            }
            else if (user == 2 && computer == 1)
            {
                // user wins
                WriteLine("computer losess to user");
            }
            else
            {
                WriteLine("error");
            }
        }
    }
}
