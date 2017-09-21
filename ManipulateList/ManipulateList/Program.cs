using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateList
{
    class Program
    {
        static void Main(string[] args)
        {
            var groceries = new List<string>();

            string itemInList;
            string input;
            string output;
            string inputWithPrefixRemoved;
            string prefix;

            Console.WriteLine("Grocery List: To add an item type + item, to remove an item type - item, to clear the list type --, to exit type exit");

            while (true)
            {
                Console.WriteLine("Please add, remove, or clear ");
                input = Console.ReadLine();
                inputWithPrefixRemoved = input.Substring(2);
                prefix = input.Substring(0, 2);
            }

            Console.ReadLine();
        }
    }
}
