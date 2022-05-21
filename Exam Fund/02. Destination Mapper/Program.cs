using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> destinations = new List<string>();
            int travelPoints = 0;

            string input = Console.ReadLine();
            string pattern =
                @"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match currMatch in matches)
            {
                string currDestination = currMatch.Groups["destination"].Value;

                destinations.Add(currDestination);

                travelPoints += currDestination.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
