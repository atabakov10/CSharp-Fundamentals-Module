using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonimList =
                new Dictionary<string, List<string>>();

            for (int i = 0; i < pairCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonimList.ContainsKey(word))
                {
                    synonimList[word].Add(synonym);
                }
                else
                {
                    List<string> newSymList = new List<string>() { synonym };

                    synonimList.Add(word, newSymList);
                }

            }
            foreach (var item in synonimList)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }

        }
    }
}
