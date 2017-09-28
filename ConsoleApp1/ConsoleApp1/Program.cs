using ConsoleApp2;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Dictionary<string, long> phoneBook = new Dictionary<string, long>();
            phoneBook.Add("John", 004512345678);
            phoneBook.Add("Smith", 003312345678);
            phoneBook.Add("Elane", 00131234567890);

            Console.WriteLine("- Type '1' for displaying all persons \n- Type '2' for searching a person  \n- Type '3' to terminate the console");
            var searchTerm = Console.ReadLine();

            if (searchTerm == "1")
            {
                foreach (KeyValuePair<string, long> item in phoneBook)
                {
                    Console.WriteLine(item.Key + "'s phone number is " + item.Value);
                }
            }
            else if (searchTerm == "2")
            {
                Console.WriteLine("\n-----------------------------------\nSearch for a specific person:");

                var newSearchTerm = Console.ReadLine();
                bool succes = false;

                //long phoneNumber = 1234;
                //phoneBook.TryGetValue("John", out phoneNumber);

                foreach (KeyValuePair<string, long> item in phoneBook)
                {
                    if (newSearchTerm.ToLower() == item.Key.ToLower())
                    {
                        Console.WriteLine(item.Key + "'s phone number is " + item.Value);
                        succes = true;
                    }
                }

                if (succes == false)
                {
                    Console.WriteLine(string.Format("The phone number for {0} is not in our book", newSearchTerm));
                }
            }
            else
            {
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
    }
}