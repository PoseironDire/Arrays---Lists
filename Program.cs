using System;
using System.Collections.Generic;

namespace Arrays___Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] activities = new string[5];

            Console.WriteLine("Type 5 of your favorite Activities!");

            for (int i = 0; i < activities.Length; i++)
            {
                activities[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere are your Activities in alphabetical order:");

            Array.Sort(activities);

            for (int i = 0; i < activities.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + activities[i]);
            }

            Console.ReadLine();

            Console.WriteLine("Colors:");

            List<string> colors = new List<string>();

            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Yellow");
            colors.Add("Purple");
            colors.Add("Orange");

            Color(colors);

            Console.ReadLine();

            Console.WriteLine("You can remove a color by typing in it's Rank Value");

            bool lyckad = false;

            while (!lyckad == true)
            {

                string value = Console.ReadLine();
                int result;
                lyckad = int.TryParse(value, out result);

                result = result - 1;

                //Ifall man skriver in 7 så crashar programmet och jag ha ingen aning hur man ska lösa det
                if (lyckad == false || result > colors.Count || result < 1)
                {
                    Console.WriteLine("'Inrecognized Value'");
                    lyckad = false;
                }
                else
                {
                    Console.WriteLine(colors[result] + " has been Removed!");
                    colors.RemoveAt(result);
                    Color(colors);
                }
            }
            Console.ReadKey();
        }
        static void Color(List<string> colors)
        {

            for (int i = 0; i < colors.Count; i++)
            {
                int rank = i + 1;
                Console.WriteLine("Rank: " + rank + ". " + colors[i]);
            }
        }
    }
}
