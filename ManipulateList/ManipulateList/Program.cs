﻿using System;
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

            Console.WriteLine("Grocery List: To add an item type + item");
            Console.WriteLine("To remove an item type - item");
            Console.WriteLine("To clear the list type --");
            Console.WriteLine("To exit hit enter");


            while (true)
            {
                Console.WriteLine("Please add, remove, or clear ");
                input = Console.ReadLine();
                inputWithPrefixRemoved = input.Substring(2);
                prefix = input.Substring(0, 2);
                
                switch (prefix)
                {
                    case "+ ":
                        groceries.Add(inputWithPrefixRemoved);
                        break;

                    case "- ":
                        groceries.Remove(inputWithPrefixRemoved);
                        break;
                    case "--": 
                        groceries.Clear();
                        break;
                    default:
                        System.Application.Exit();
                }

                for (int i = 0; i < groceries.Count; i++)
                {
                    Console.WriteLine($"Your list now contains:");
                    Console.Write($"{groceries[i]} , ");
                }
            }
        }
    }
}


