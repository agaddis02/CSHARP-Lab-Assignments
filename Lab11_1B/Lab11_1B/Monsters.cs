using System;
using static System.Console;
using System.IO;

namespace Lab11_1B
{
    class Monsters
    {
        /*
         * Adam Gaddis
         * This is the monster class
         */
        private string type;
        private int size;

        public Monsters(string ty, int sz)
        {
            type = ty;
            size = sz;
            WriteLine("Type: " + type);
            WriteLine("Size " + size);
        }
        public int getSize()
        { 
			return size;
		}
        public string getType()
        {
            return type;
        }

	
		
    }
}

