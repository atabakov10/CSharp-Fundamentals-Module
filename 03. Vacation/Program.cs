using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            int totalDays = 0;
            int spendingDays = 0;

            while (moneyAvailable < moneyNeeded)
            {
                string moneyAction = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                totalDays++;
                if (moneyAction == "save")
                {
                    moneyAvailable += amount;
                    if (moneyAvailable >= moneyNeeded)
                    {
                        Console.WriteLine($"You saved the money for {totalDays} days.");
                        break;
                    }
                    spendingDays = 0;
                }
                else if (moneyAction == "spend")
                {
                    spendingDays++;
                    if (spendingDays >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(totalDays);
                        break;
                    }
                    moneyAvailable -= amount;
                    if (moneyAvailable < 0)
                    {
                        moneyAvailable = 0;
                    }
                }

            }

        }
    }
}
