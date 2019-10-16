using System;
using static System.Random;
using static System.Console;

namespace Lab7_3A
{
    /*
     * Adam Gaddis
     * This rogram plays a basic game of rock, paper, scissors with the user
     * */
    class Program
    {
        enum Choices  {Rock, Paper, Scissors, Lizard, Spock};

        static void Main(string[] args)
        {

            Choices usersChoice;
            ;
            WriteLine("Enter 0 for rock, 1 for paper, 2 for scissors, 3 for lizard, 4 for spock");
            usersChoice = (Choices)int.Parse(ReadLine());
            
            DetermineWinner(ProgramChoice(), usersChoice);
        }

        static Choices ProgramChoice()
        {
            int rando;
            Choices computerPlay;
            Random random = new Random();

            rando = random.Next(0, 4);
            computerPlay = (Choices)rando;

            

            return computerPlay;
        }

        static void DetermineWinner(Choices computer, Choices user)
        {
            switch (computer)
            {
                case Choices.Rock:
                    WriteLine("computer: Rock");
                    break;
                case Choices.Paper:
                    WriteLine("computer: Paper");
                    break;
                case Choices.Scissors:
                    WriteLine("computer: Scissors");
                    break;
                case Choices.Lizard:
                    WriteLine("computer: Lizard");
                    break;
                case Choices.Spock:
                    WriteLine("computer: Spock");
                    break;
                default:
                    WriteLine("computer: Unknown");
                    break;
            }

            switch (user)
            {
                case Choices.Rock:
                    WriteLine("user: Rock");
                    break;
                case Choices.Paper:
                    WriteLine("user: Paper");
                    break;
                case Choices.Scissors:
                    WriteLine("user: Scissors");
                    break;
                case Choices.Lizard:
                    WriteLine("user: Lizard");
                    break;
                case Choices.Spock:
                    WriteLine("user: Spock");
                    break;
                default:
                    WriteLine("user: Unknown");
                    break;
            }

            // Rocks
            if (computer == Choices.Rock && user == Choices.Scissors)
            {
                // Comp wins
                WriteLine("computer beats user");
            }
            else if (computer == Choices.Rock && user == Choices.Paper)
            {
                // comp loses
                WriteLine("computer losess to user");
            }
            else if (computer == Choices.Rock && user == Choices.Rock)
            {
                // Tie
                WriteLine("computer ties with user");
            }
            else if (user == Choices.Rock && computer == Choices.Scissors)
            {
                // User wins
                WriteLine("computer losess to user");
            }
            else if (user == Choices.Rock && computer == Choices.Paper)
            {
                // User loses
                WriteLine("computer beats user");
            }
            else if (user == Choices.Rock && computer == Choices.Rock)
            {
                // Tie
                WriteLine("computer ties with user");
            }
            else if (user == Choices.Rock && computer == Choices.Lizard)
            {
                // user wins
                WriteLine("user beats computer");
            }
            else if (user == Choices.Rock && computer == Choices.Spock)
            {
                // computer wins
                WriteLine("computer beats user");
            }
            // Rocks

            // Papers
            else if (user == Choices.Paper && computer == Choices.Paper)
            {
                // Tie
                WriteLine("computer ties with user");
            }
            else if (user == Choices.Paper && computer == Choices.Scissors)
            {
                // computer wins
                WriteLine("computer beats user");
            }
            else if (user == Choices.Paper && computer == Choices.Lizard)
            {
                // computer wins
                WriteLine("computer beats user");
            }
            else if (user == Choices.Paper && computer == Choices.Spock)
            {
                // user wins
                WriteLine("user beats computer");
            }
            // Papers

            // Scissors
            else if (user == Choices.Scissors && computer == Choices.Scissors)
            {
                // Tie
                WriteLine("computer ties with user");
            }

            else if (user == Choices.Scissors && computer == Choices.Paper)
            {
                // user wins
                WriteLine("computer losess to user");
            }
            else if (user == Choices.Scissors && computer == Choices.Lizard)
            {
                // user wins
                WriteLine("computer losess to user");
            }
            else if (user == Choices.Scissors && computer == Choices.Spock)
            {
                // computer wins
                WriteLine("user losess to computer");
            }
            // Scissors

            // Lizard
            else if (user == Choices.Lizard && computer == Choices.Scissors)
            {
                //computer Wins
                WriteLine("user losess to computer");
            }
            else if (user == Choices.Lizard && computer == Choices.Paper)
            {
                // user wins
                WriteLine("user beats computer");
            }
            else if (user == Choices.Lizard && computer == Choices.Rock)
            {
                // computer wins
                WriteLine("computer beats user");
            }
            else if (user == Choices.Lizard && computer == Choices.Spock)
            {
                // user wins
                WriteLine("user beats computer");
            }
            // Lizard

            // Spock
            else if (user == Choices.Spock && computer == Choices.Scissors)
            {
                // user wins
                WriteLine("computer losess to user");
            }
            else if (user == Choices.Spock && computer == Choices.Paper)
            {
                // computer wins
                WriteLine("computer beats user");
            }
            else if (user == Choices.Spock && computer == Choices.Rock)
            {
                // user wins
                WriteLine("user beats computer");
            }
            else if (user == Choices.Spock && computer == Choices.Lizard)
            {
                // computer wins
                WriteLine("computer beats computer");
            }
            // Spock

            else
            {
                WriteLine("error");
            }
        }
    }
}
