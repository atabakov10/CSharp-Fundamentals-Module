using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            Dictionary<string, int> carsDistance = new Dictionary<string, int>();
            Dictionary<string, int> carsFuel = new Dictionary<string, int>();


            for (int i = 0; i < times; i++)
            {
                string[] car = Console.ReadLine()
                     .Split('|')
                     .ToArray();

                string carName = car[0];
                int mileague = int.Parse(car[1]);
                int fuel = int.Parse(car[2]);

                carsDistance[carName] = mileague;
                carsFuel[carName] = fuel;
            }
            var command = Console.ReadLine()
                .Split(" : ")
                .ToArray();
            while (command[0] != "Stop")
            {
                if (command[0] == "Drive")
                {

                }
            }
        }
    }
    //class Cars
    //{
    //    public Cars(string car, int distance, int fuel)
    //    {
    //        this.Car = car;

    //        this.Distance = distance;

    //        this.Fuel = fuel;
    //    }
    //    public string Car { get; set; }

    //    public int Distance { get; set; }

    //    public int Fuel { get; set; }
    //}
}
