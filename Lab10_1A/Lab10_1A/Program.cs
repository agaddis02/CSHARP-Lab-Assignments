using System;
using static System.Console;
using System.IO;

namespace Lab10_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            VIPAccount VIP = new VIPAccount();



            account.setValues("B.Bunny", 1292,999257 );
            VIP.setValues("Tweetie", 1500, 999265);

            WriteLine("B.Bunny Account");
            account.deposit(200);
            account.addInterest();
            account.printData();
            WriteLine("-----------------");


            WriteLine("Tweetie");
            VIP.withdraw(100);
            VIP.addInterest();
            VIP.printData();
            WriteLine("-----------------");

        }
    }
}
