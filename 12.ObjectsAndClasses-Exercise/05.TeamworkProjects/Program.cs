using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamsCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");

                var creator = newTeam[0];
                var teamName = newTeam[1];

                Team team = new Team(teamName, creator);

                bool teamExists = teams
                    .Select(x => x.TeamName)
                    .Contains(teamName);

                bool creatorExists = teams
                    .Select(x => x.Creator)
                    .Contains(creator);

                if (!teamExists)
                {
                    if (!creatorExists)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            var command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] newMember = command.Split("->");
                var user = newMember[0];
                var teamName = newMember[1];

                bool teamExists = teams
                    .Select(x => x.TeamName)
                    .Contains(teamName);

                bool creatorExists = teams
                    .Select(x => x.Creator)
                    .Contains(user);

                bool memberExists = teams
                    .Select(x => x.Members)
                    .Any(x => x.Contains(user));

                if (!teamExists)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (creatorExists || memberExists)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    var index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Members.Add(user);
                }

                command = Console.ReadLine();
            }

            Team[] teamWithMembers = teams.OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .Where(x => x.Members.Count > 0)
                .ToArray();

            Team[] teamWithoutMembers = teams.OrderBy(x => x.TeamName)
                .Where(x => x.Members.Count == 0)
                .ToArray();

            StringBuilder output = new StringBuilder();

            foreach (Team team in teamWithMembers)
            {
                output.AppendLine($"{team.TeamName}");
                output.AppendLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    output.AppendLine($"-- {member}");
                }
            }

            output.AppendLine("Teams to disband:");

            foreach (Team team in teamWithoutMembers)
            {
                output.AppendLine(team.TeamName);
            }

            Console.WriteLine(output.ToString());
        }
    }

    class Team
    {
        public Team(string teamName, string creator)
        {
            Creator = creator;
            TeamName = teamName;
            Members = new List<string>();
        }

        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
