using System;
using System.Linq;
using System.Text;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string instrInfo;
            while ((instrInfo = Console.ReadLine()) != "Decode")
            {
                string[] instrArgs = instrInfo.Split('|', StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
                string instrType = instrArgs[0];
                if (instrType == "Move")
                {
                    int numberOfLetters = int.Parse(instrArgs[1]);

                    StringBuilder strBuilder = new StringBuilder(encryptedMessage);
                    for (int i = 0; i < numberOfLetters; i++)
                    {
                        
                    }

                }
                else if (instrType == "Insert")
                {
                    int index = int.Parse(instrArgs[1]);
                    string element = instrArgs[2];
                }





            }
        }
        static void MoveNumberOfLetters(int numberofLetters)
        {
            int validation = numberofLetters;
        
        }
    }
}
