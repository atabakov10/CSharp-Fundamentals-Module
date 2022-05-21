using System;
using System.Linq;

namespace _01._String_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                       .ToArray();
                if (command.StartsWith("Change"))
                {
                    
                    string charToReplace = commandArgs[1];


                    string replacement = commandArgs[2];

                    input = input.Replace(charToReplace, replacement);
                    Console.WriteLine(input);
                }
                else if (command.StartsWith("Includes"))
                {
                   
                    string substring = commandArgs[1];


                    if (input.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command.StartsWith("End"))
                {
                    
                    string substring = commandArgs[1];
                    if (input.EndsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command.StartsWith("Uppercase"))
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (command.StartsWith("FindIndex"))
                {
                   
                    string findIndex = commandArgs[1];
                   int index = input.IndexOf(findIndex);
                    Console.WriteLine(index);
                }
                else if (command.StartsWith("Cut"))
                {

                    int startIndex = int.Parse(commandArgs[1]);
                    int count = int.Parse(commandArgs[2]);
                    string cut = input.Substring(startIndex, count);
                    Console.WriteLine(cut);
                }

            }
        }
    }
}
