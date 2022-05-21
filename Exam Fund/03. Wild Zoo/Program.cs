using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wild_Zoo
{
    class Animal
    {
        public Animal(string name, int dailyFoodLimit, string area)
        {
            this.Name = name;
            this.DailyFoodLimit = dailyFoodLimit;
            this.Area = area;
        }
        public string Name { get; set; }

        public int DailyFoodLimit { get; set; }

        public string Area { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalsInfo = new List<Animal>();

            string command;
            while ((command = Console.ReadLine()) != "EndDay")
            {
                string[] commandArgs = command.Split(": ", '-', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string commType = commandArgs[0];
                if (commType == "Add")
                {
                    string[] properties = commandArgs[1].Split('-', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string name = properties[0];
                    int dailyFoodLimit = int.Parse(properties[1]);
                    string area = properties[2];
                    if (animalsInfo.Any(x => x.Name == name))
                    {
                        animalsInfo.FirstOrDefault(x => x.Name == name).DailyFoodLimit += dailyFoodLimit;
                    }
                    else
                    {
                        Animal newAnimal = new Animal(name, dailyFoodLimit, area);
                        animalsInfo.Add(newAnimal);
                    }
                }
                else if (commType == "Feed")
                {
                    string[] properties = commandArgs[1].Split('-', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string name = properties[0];
                    int food = int.Parse(properties[1]);
                    if (animalsInfo.Any(x => x.Name == name))
                    {
                        var animal = animalsInfo.FirstOrDefault(x => x.Name == name);
                        animal.DailyFoodLimit -= food;
                        if (animal.DailyFoodLimit <= 0)
                        {
                            animalsInfo.Remove(animal);
                            Console.WriteLine($"{name} was successfully fed");
                        }
                    }
                }

            }
            Console.WriteLine("Animals:");

            foreach (var finalAnimal in animalsInfo)
            {
                Console.WriteLine($" {finalAnimal.Name} -> {finalAnimal.DailyFoodLimit}g");
            }
            Console.WriteLine("Areas with hungry animals:");

            var areas = animalsInfo.Where(x => x.DailyFoodLimit > 0).GroupBy(x => x.Area).ToList();
            foreach (var area in areas)
            {
                Console.WriteLine($" {area.Key.ToString()}: {area.Count()}");
            }




        }
    }
}
