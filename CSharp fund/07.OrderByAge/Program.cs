using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge2
{
    class Person
    {
        public Person(string name, string id, int Age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = Age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPerson = new List<Person>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split();
                string name = info[0];
                string Id = info[1];
                int age = int.Parse(info[2]);
                Person person = new Person(name, Id, age);
                Person person2 = allPerson.FirstOrDefault(x => x.ID == Id);
                if (person2 == null)
                {
                    allPerson.Add(person);
                }
                else
                {
                    person2.Name = name;
                    person2.Age = age;
                    person2.ID = Id;
                }
                input = Console.ReadLine();
            }
            allPerson = allPerson.OrderBy(x => x.Age).ToList();

            foreach (Person person in allPerson)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}