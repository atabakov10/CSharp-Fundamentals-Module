using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double resto = double.Parse(Console.ReadLine());
            double hundreds = resto * 100;
            int count = 0;
            while (hundreds > 0)
            {
                if (hundreds >= 200)
                {
                    count++;
                    hundreds -= 200;
                    continue;
                }
                else if (hundreds >= 100)
                {
                    count++;
                    hundreds -= 100;
                    continue;
                }
                else if (hundreds >= 50)
                {
                    count++;
                    hundreds -= 50;
                    continue;
                }
                else if (hundreds >= 20)
                {
                    count++;
                    hundreds -= 20;
                    continue;
                }
                else if (hundreds >= 10)
                {
                    count++;
                    hundreds -= 10;
                    continue;
                }
                else if (hundreds >= 5)
                {
                    count++;
                    hundreds -= 5;
                    continue;
                }
                else if (hundreds >= 2)
                {
                    count++;
                    hundreds -= 2;
                    continue;
                }
                else if (hundreds >= 1)
                {
                    count++;
                    hundreds -= 1;
                    continue;
                }
            }
            Console.WriteLine(count);
        }
    }
}
