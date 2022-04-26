using System;
using System.Collections.Generic;

namespace ListOfDictionariesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> person1 = new Dictionary<string, string>();

            person1.Add("firstName", "Pearce");
            person1.Add("lastName", "Odegard");
            person1.Add("favColor", "Orange");
            person1.Add("favCuisine", "Indian");

            Console.WriteLine("~~~~~~~~~");
            foreach (KeyValuePair<string, string> kvp in person1)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Console.WriteLine("~~~~~~~~~");

            Dictionary<string, string> person2 = new Dictionary<string, string>();

            person2.Add("firstName", "Zach");
            person2.Add("lastName", "Robles");
            person2.Add("favColor", "Green");
            person2.Add("favCuisine", "Japanese");

            Console.WriteLine("~~~~~~~~~");
            foreach (KeyValuePair<string, string> kvp in person2)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Console.WriteLine("~~~~~~~~~");

            // Hardcoded print statements without loops

            //Console.WriteLine("~~~~~~~~~");
            //Console.WriteLine($"First Name: {person1["firstName"]}");
            //Console.WriteLine($"Last Name: {person1["lastName"]}");
            //Console.WriteLine($"Favorite Color: {person1["favColor"]}");
            //Console.WriteLine("~~~~~~~~~");

            //Console.WriteLine("~~~~~~~~~");
            //Console.WriteLine($"First Name: {person2["firstName"]}");
            //Console.WriteLine($"Last Name: {person2["lastName"]}");
            //Console.WriteLine($"Favorite Color: {person2["favColor"]}");
            //Console.WriteLine("~~~~~~~~~");
        }
    }
}
