using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            int ticker = 0;
            int count;
            WriteLine("Enter Integers, enter a 0 when you wannt to exit");
            count = Convert.ToInt32(ReadLine());

            while(count != 0)
            {
                count = Convert.ToInt32(ReadLine());
                if (!(count % 2 == 0))
                {
                    ticker++;
                }

            };

            WriteLine(ticker);


        }
    }
}
