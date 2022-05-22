using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string nameTask = Console.ReadLine();
            int counterBadGrades = 0;
            int sumGrades = 0;
            int counterTask = 0;
            string lastTask = "";
            bool isTheGradeBad = false;
            while (nameTask != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                counterTask++;
                if (grade <= 4)
                {
                    counterBadGrades++;
                    if (counterBadGrades == badGrades)
                    {
                        Console.WriteLine($"You need a break, {counterBadGrades} poor grades.");
                        isTheGradeBad = true;
                        break;
                    }
                }
                lastTask = nameTask;
                nameTask = Console.ReadLine();

            }
            if (isTheGradeBad == false)
            {
                double average = sumGrades * 1.0 / counterTask;
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {counterTask}");
                Console.WriteLine($"Last problem: {lastTask}");
            }




        }
    }
}
