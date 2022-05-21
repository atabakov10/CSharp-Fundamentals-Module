using System;
using System.Collections.Generic;
using System.Linq;



namespace _05.Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] teamArgs = Console.ReadLine()
                    .Split('-')
                    .ToArray();

                string creatorName = teamArgs[0];
                string teamName = teamArgs[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(t => t.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");


            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] joinArgs = command
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string memberName = joinArgs[0];
                string teamName = joinArgs[1];

                Team team = teams.FirstOrDefault(t => t.Name == teamName);
            }

        }

    }
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            this.Name = teamName;
            this.Creator = creatorName;

            this.Members = new List<string>();
        }
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public void AddMember(string member)
        {
            this.Members.Add(member);
        }
    }
}
