using System;
using System.Text.RegularExpressions;

namespace _02._Message_Decrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            Regex pattern = new Regex(@"^(\$|\%)(?<tag>[A-Z]{1}[a-z]{2,})\1: (?<decryptedMessage>\[\d+\]\|\[\d+\]\|\[\d+\]\|)$");
            
            for (int i = 0; i < numbers; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = pattern.Matches(input);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        string tag = match.Groups["tag"].Value;
                        string decryptedMessage = match.Groups["decryptedMessage"].Value;
                        var check = pattern.IsMatch(input);

                        Regex decryptedPattern = new Regex(@"([\d]+)");
                        MatchCollection decryptedNumbers = decryptedPattern.Matches(decryptedMessage);
                        string decryptedMsg = String.Empty;
                        foreach (Match number in decryptedNumbers)
                        {
                            int numberValue = int.Parse(number.Groups[1].Value);
                            char a = (char)numberValue;
                            decryptedMsg += a;
                        }
                        Console.WriteLine($"{tag}: {decryptedMsg}");


                    }
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }

               

               
            }
        }
    }
}
