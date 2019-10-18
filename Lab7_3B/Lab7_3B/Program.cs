using System;
using static System.Random;
using static System.Console;

namespace Lab7_3B
{
    /*
     * Adam Gadis
     * This program creates a game of black jack for the user
     * */
     

    // Create enum for cards
    enum Cards {Ace = 1, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0, houseScore = 0;

            Random random = new Random();


            houseScore = housePlay(random);
            WriteLine("House Score is: " + houseScore);

            playerPickCard(ref playerScore, random);

            playerPickCard(ref playerScore, random);

            WriteLine("Would you like to pick another card? Yes or No?");
            bool playAgain = ReadLine().Equals("Yes") || ReadLine().Equals("yes");
            if (playAgain)
            {
                playerPickCard(ref playerScore, random);
                WriteLine("Your Score was: " + playerScore);
                if (playerScore > 21)
                {
                    WriteLine("You Busted");
                }
                else if ((playerScore <= 21) && (playerScore > houseScore))
                {
                    WriteLine("You win");
                }
                else if ((houseScore <= 21) && (playerScore < houseScore))
                {
                    WriteLine("You lost");
                }
                else if ((houseScore == playerScore) && (houseScore <= 21) && (playerScore <= 21))
                {
                    WriteLine("Its a tie");
                }
            }
            else
            {
                WriteLine("Your Score was: " + playerScore);
                if (playerScore > 21)
                {
                    WriteLine("You Busted");
                }
                else if ((playerScore <= 21) && (playerScore > houseScore))
                {
                    WriteLine("You win");
                }
                else if ((houseScore <= 21) && (playerScore < houseScore))
                {
                    WriteLine("You lost");
                }
                else if ((houseScore == playerScore) && (houseScore <= 21) && (playerScore <= 21))
                {
                    WriteLine("Its a tie");
                }
            }
            
        }



        public static void drawTheCard(Cards card)
        {

            if (card == Cards.Ace)
            {
                WriteLine("*****");
                WriteLine("* A *");
                WriteLine("*****");
            }
            else if (card == Cards.One)
            {
                WriteLine("*****");
                WriteLine("* 1 *");
                WriteLine("*****");
            }
            else if (card == Cards.Two)
            {
                WriteLine("*****");
                WriteLine("* 2 *");
                WriteLine("*****");
            }
            else if (card == Cards.Three)
            {
                WriteLine("*****");
                WriteLine("* 3 *");
                WriteLine("*****");
            }
            else if (card == Cards.Four)
            {
                WriteLine("*****");
                WriteLine("* 4 *");
                WriteLine("*****");
            }
            else if (card == Cards.Five)
            {
                WriteLine("*****");
                WriteLine("* 5 *");
                WriteLine("*****");
            }
            else if (card == Cards.Six)
            {
                WriteLine("*****");
                WriteLine("* 6 *");
                WriteLine("*****");
            }
            else if (card == Cards.Seven)
            {
                WriteLine("*****");
                WriteLine("* 7 *");
                WriteLine("*****");
            }
            else if (card == Cards.Eight)
            {
                WriteLine("*****");
                WriteLine("* 8 *");
                WriteLine("*****");
            }
            else if (card == Cards.Nine)
            {
                WriteLine("*****");
                WriteLine("* 9 *");
                WriteLine("*****");
            }
            else if (card == Cards.Ten)
            {
                WriteLine("*****");
                WriteLine("* 10 *");
                WriteLine("*****");
            }
            else if (card == Cards.Jack)
            {
                WriteLine("*****");
                WriteLine("* J *");
                WriteLine("*****");
            }
            else if (card == Cards.Queen)
            {
                WriteLine("*****");
                WriteLine("* Q *");
                WriteLine("*****");
            }
            else if (card == Cards.King)
            {
                WriteLine("*****");
                WriteLine("* K *");
                WriteLine("*****");
            }
        }



        // returns the value of the card
        public static int getPoints(Cards card)
        {
            int aceValue;
            switch (card)
            {
                case Cards.Ace: // Ace Value, ace can be a value of 1 or 11
                    WriteLine("What value of Ace would you like, an 11 or an 1");
                    aceValue = int.Parse(ReadLine());
                    if (aceValue == 11)
                        return 11;
                    else if (aceValue == 1)
                        return 1;
                    else
                        return 1;
                case Cards.One: // One Value
                    return 1;
                case Cards.Two: // Two value 
                    return 2;
                case Cards.Three: // Three Value
                    return 3;
                case Cards.Four: // Four Value
                    return 4;
                case Cards.Five: // Five Value
                    return 5;
                case Cards.Six: // Six Value
                    return 6;
                case Cards.Seven: // Seven Value
                    return 7;
                case Cards.Eight: // Eight Value
                    return 8;
                case Cards.Nine: // Nine Value
                    return 9;
                case Cards.Ten: // Ten Value 
                    return 10;
                case Cards.Jack: // Jack Value
                    return 11;
                case Cards.Queen: // Queen Value
                    return 12;
                case Cards.King: //  King Value
                    return 13;
                default: return 0; //  Zero value to keep method happy

                

            }

            
        }
        public static int housePlay(Random random)
        {
            return random.Next(2, 22);
        }

        public static void playerPickCard(ref int totalScore, Random random)
        {
            int num = random.Next(1, 14);
            Cards pick;
            pick = (Cards)num;

            drawTheCard(pick);
          
            totalScore+=getPoints(pick);
        }
    }
}
