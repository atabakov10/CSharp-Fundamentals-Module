using System;
using System.Linq;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commandArgs = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandArgs[0];

                if (commandType == "TakeOdd")
                {
                    char[] oddChars = password
                        .Where((symbol, index) => index % 2 != 0)
                        .ToArray();

                    password = string.Join("", oddChars);
                    Console.WriteLine(password);
                }
                else if (commandType == "Cut")
                {
                    int indexForRemoving = int.Parse(commandArgs[1]);
                    int lengthForRemoving = int.Parse(commandArgs[2]);

                    password = password.Remove(indexForRemoving, lengthForRemoving);

                    Console.WriteLine(password);
                }
                else if (commandType == "Substitute")
                {
                    string substring = commandArgs[1];
                    string substitute = commandArgs[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                

                command = Console.ReadLine();
            }
             

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
