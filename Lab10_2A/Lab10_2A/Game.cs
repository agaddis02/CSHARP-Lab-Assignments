using System;
using static System.Console;
using System.IO;
using static System.Random;

namespace Lab10_2A
{
    class Game
    {
        protected int dice;

        public void drawDice(int dice)
        {
            switch(dice)
            {
                case 1:
                    WriteLine("---------");
                    WriteLine("|       |");
                    WriteLine("|   X   |");
                    WriteLine("|       |");
                    WriteLine("---------");
                    break;
                case 2:
                    WriteLine("---------");
                    WriteLine("| X     |");
                    WriteLine("|       |");
                    WriteLine("|     X |");
                    WriteLine("---------");
                    break;
                case 3:
                    WriteLine("---------");
                    WriteLine("| X     |");
                    WriteLine("|   X   |");
                    WriteLine("|      X|");
                    WriteLine("---------");
                    break;
                case 4:
                    WriteLine("---------");
                    WriteLine("|X     X|");
                    WriteLine("|       |");
                    WriteLine("|X     X|");
                    WriteLine("---------");
                    break;
                case 5:
                    WriteLine("---------");
                    WriteLine("|X     X|");
                    WriteLine("|   X   |");
                    WriteLine("|X     X|");
                    WriteLine("---------");
                    break;
                case 6:
                    WriteLine("---------");
                    WriteLine("|X     X|");
                    WriteLine("|X     X|");
                    WriteLine("|X     X|");
                    WriteLine("---------");
                    break;
                default:
                    WriteLine("Unknown Number");
                    break;
            }
        }
    }
}
