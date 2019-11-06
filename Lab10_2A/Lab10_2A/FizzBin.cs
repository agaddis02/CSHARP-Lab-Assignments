using System;
using static System.Console;
using System.IO;
using static System.Random;

namespace Lab10_2A
{
    class FizzBin : Game
    {
        protected int dice1, dice2;
        Random random = new Random();
        private void rollDice(int di1, int di2, Random random)
        {

            di1 = random.Next(1,7);
            di2 = random.Next(1, 7);

            dice1 = di1;
            dice2 = di2;

            drawDice(dice1);
            drawDice(dice2);
            
        }

        public void runGame()
        {
            bool done = false;
            int total = 0;
            while(done == false)
            {
                rollDice(dice1, dice2, random);

                if(dice1 == 5 || dice2 == 5)
                {
                    total += 5;
                }

                else if(dice1 == dice2)
                {
                    WriteLine("You Rolled Doubles, Bye Bye");
                    done = true;
                }

                if(total == 20)
                {
                    WriteLine("Congratulations, You Win");
                    done = true;

                }
            }
        }
    }
}
