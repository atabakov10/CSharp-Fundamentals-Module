using System;

namespace midExam
{
    class Program
    {
        static void Main(string[] args)
        {
           float budget = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float priceForPackageOfFloar = float.Parse(Console.ReadLine());
            float priceForSingleEgg = float.Parse(Console.ReadLine());
            float priceForSingleApron = float.Parse(Console.ReadLine());
            double freePackagesFloar = students / 5;
            double percentage = students * 1.2;




            double costOfItems = priceForSingleApron * (percentage)
            + priceForSingleEgg * 10 * (students) + priceForPackageOfFloar * (students - freePackagesFloar);
            
            double neededMoney = costOfItems - budget;
            if (costOfItems <= budget)
            {
                Console.WriteLine($"Items purchased for {costOfItems + 6:f2}$.");
            }
            else if (costOfItems > budget)
            {
                Console.WriteLine($"{neededMoney:f2}$ more needed.");
            }
        }
    }
}

