using System;
using System.Collections.Generic;

namespace ListOfDictionariesLoops
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

            Dictionary<string, string> person2 = new Dictionary<string, string>();
            person2.Add("firstName", "Zach");
            person2.Add("lastName", "Robles");
            person2.Add("favColor", "Green");
            person2.Add("favCuisine", "Japanese");

            Dictionary<string, string> person3 = new Dictionary<string, string>();
            person3.Add("firstName", "Titi");
            person3.Add("lastName", "Milford");
            person3.Add("favColor", "Pink");
            person3.Add("favCuisine", "Martian");

            List<Dictionary<string, string>> people = new List<Dictionary<string, string>>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);

            // call the PrintPeople method to print out all the 'person' dictionaries in the people list

        }

        public static void PrintPeople(List<Dictionary<string, string>> listOfDictionaries)
        {
            foreach (Dictionary<string, string> person in listOfDictionaries)
            {
                Console.WriteLine("~~~~~~~~~");
                foreach (KeyValuePair<string, string> kvp in person)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
                Console.WriteLine("~~~~~~~~~");
            }
        }
    }
}
