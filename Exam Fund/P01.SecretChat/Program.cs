using System;
using System.Linq;

namespace P01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] commandArgs = command.Split(":|:",
                    StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandArgs[0];

                if (commandType == "InsertSpace")
                {
                    int insertIndex = int.Parse(commandArgs[1]);

                    message = message.Insert(insertIndex, " ");
                }
                else if (commandType == "Reverse")
                {
                    string substring = commandArgs[1];
                    if (message.Contains(substring))
                    {
                        int wordIndex = message.IndexOf(substring);
                        message = message.Remove(wordIndex, substring.Length);
                        message = message + string.Join("", substring.Reverse());
                    }
                    else
                    {
                        Console.WriteLine("error");
                        command = Console.ReadLine();

                        continue;
                    }



                }
                else if (commandType == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacementText = commandArgs[2];

                    message = message.Replace(substring, replacementText);
                }


                Console.WriteLine(message);

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
