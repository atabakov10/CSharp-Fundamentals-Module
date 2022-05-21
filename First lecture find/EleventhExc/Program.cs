using System;

namespace EleventhExc
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());

            if (times > 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
            }
            else
            {
                for (int i = times; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
        }

    }
}      
        
    

