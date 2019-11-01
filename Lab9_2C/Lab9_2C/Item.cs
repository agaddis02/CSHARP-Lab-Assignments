using System;
using static System.Console;
using System.IO;


namespace Lab9_2C
{
    /*
     * Adam Gaddis
     * This class stores value of name, price, and quanity of an item
     * */

    class Item
    {
        string name;
        double price;
        int quantity;

        public Item(string nm, double pr, int q)
        {
            name = nm;
            price = pr;
            quantity = q;
        }

        public void printData()
        {
            WriteLine("Name: " + name);
            WriteLine("Price: " + price);
            WriteLine("Quantity: " + quantity);
        }

        public string getName()
        {
            return name;
        }

        public double getPrice()
        {
            return price;
        }

        public int getQuantity()
        {
            return quantity;
        }


    }
}
