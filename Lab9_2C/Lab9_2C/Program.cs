using System;
using static System.Console;
using System.IO;

namespace Lab9_2C
{
    /*
     * Adam Gaddis
     * This program uses the item classes to build a shopping cart and caluate the total price
     * */
    class Program
    {
        static void Main(string[] args)
        {

            double total = 0, grandtotal =0;
            string hName = " ";
            Item[] grocerys = new Item[5];

            grocerys[0] = new Item("Carrots", 1.04, 3);
            grocerys[1] = new Item("Rice", 2.50, 1);
            grocerys[2] = new Item("Milk", 2.98, 2);
            grocerys[3] = new Item("Cookies", 3.98, 5);
            grocerys[4] = new Item("Coffee", 5.65,1);


            for (int i = 0; i < grocerys.Length; i++)
            {
                grocerys[i].printData();
                grocerys[i].getPrice();
                grocerys[i].getQuantity();

                grandtotal += (grocerys[i].getPrice() * grocerys[i].getQuantity());

                if ((grocerys[i].getPrice() * grocerys[i].getQuantity()) > total)
                {
                    total = grocerys[i].getPrice() * grocerys[i].getQuantity();
                    hName = grocerys[i].getName();
                    
                }

                WriteLine("Current ShoppingnCart Price is: " + grandtotal);
                WriteLine("----------------------------------------------");

            }

            WriteLine("-----------------Final Price------------------");
            WriteLine("----------------Shopping Cart: " + grandtotal);
            WriteLine("----------------Most Expensive Item: " + hName + ", Total Spent: " + total);
        }
    }
}
