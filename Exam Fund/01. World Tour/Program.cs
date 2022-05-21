using System;
using System.Linq;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopsStr = Console.ReadLine();

            string cmdInfo;
            while ((cmdInfo = Console.ReadLine()) != "Travel")
            {
                string[] cmdArgs = cmdInfo
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];

                if (cmdType == "Add Stop")
                {
                    int insertIndex = int.Parse(cmdArgs[1]);
                    string insertString = cmdArgs[2];

                    stopsStr = InsertStringAtIndex(stopsStr, insertIndex, insertString);
                    Console.WriteLine(stopsStr);
                }
                else if (cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    stopsStr = RemoveStringInRange(stopsStr, startIndex, endIndex);
                    Console.WriteLine(stopsStr);
                }
                else if (cmdType == "Switch")
                {
                    string oldStr = cmdArgs[1];
                    string newStr = cmdArgs[2];

                    stopsStr = ReplaceAllOccurances(stopsStr, oldStr, newStr);

                    Console.WriteLine(stopsStr);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stopsStr}");
        }

        static string InsertStringAtIndex(string originalStr, int insertIndex, string insertString)
        {
            if (!IsIndexValid(originalStr, insertIndex))
            {
                return originalStr;
            }

            string modifiedStr = originalStr.Insert(insertIndex, insertString);
            return modifiedStr;
        }

        static string RemoveStringInRange(string originalStr, int startIndex, int endIndex)
        {
            if (!IsIndexValid(originalStr, startIndex))
            {
                return originalStr;
            }

            if (!IsIndexValid(originalStr, endIndex))
            {
                return originalStr;
            }
            string modifiedStr = originalStr.Remove(startIndex, endIndex - startIndex + 1);
            return modifiedStr;
        }

        static string ReplaceAllOccurances(string originalStr, string oldStr, string newStr)
        {
            string modifiedString = originalStr.Replace(oldStr, newStr);
            return modifiedString;
        }

        static bool IsIndexValid(string str, int index)
        {
            return index >= 0 && index < str.Length;
        }
    }
}
