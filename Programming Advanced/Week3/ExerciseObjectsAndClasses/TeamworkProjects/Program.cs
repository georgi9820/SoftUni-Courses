int countTeams = int.Parse(Console.ReadLine());
Dictionary<string, Team> teams = new Dictionary<string, Team>();
List<string> disbands = new List<string>();

for (int i = 0; i < countTeams; i++)
{
    string teamData = Console.ReadLine();
    string[] dataArr = teamData.Split("-", StringSplitOptions.RemoveEmptyEntries);
    string creator = dataArr[0];
    string teamName = dataArr[1];

    if (teams.ContainsKey(teamName))
    {
        Console.WriteLine($"Team {teamName} was already created!");
    }
    else if (teams.Any(t => t.Value.Creator == creator))
    {
        Console.WriteLine($"{creator} cannot create another team!");
    }
    else
    {
        Team team = new Team(teamName, creator);
        teams.Add(teamName, team);
        Console.WriteLine($"Team {teamName} has been created by {creator}!");
    }
}

string command = Console.ReadLine();

while (command != "end of assignment")
{
    string memberJoining = command.Split("->")[0];
    string teamJoining = command.Split("->")[1];

    if (!teams.ContainsKey(teamJoining))
    {
        Console.WriteLine($"Team {teamJoining} does not exist!");
    }
    else if (teams.Any(t => t.Value.Members.Contains(memberJoining)) || teams[teamJoining].Creator == memberJoining)
    {
        Console.WriteLine($"Member {memberJoining} cannot join team {teamJoining}!");
    }
    else
    {
        if (teams.ContainsKey(teamJoining))
        {
            teams[teamJoining].Members.Add(memberJoining);
        }
    }

    command = Console.ReadLine();
}

var sortedTeams = teams.OrderByDescending(t => t.Value.Members.Count)
                              .ThenBy(t => t.Key);
var emptyTeams = teams.Where(t => t.Value.Members.Count == 0).Select(t => t.Key).ToList();
foreach (var emptyTeam in emptyTeams)
{
    disbands.Add(emptyTeam);
    teams.Remove(emptyTeam);
}

foreach (var team in sortedTeams)
{
    teams.Remove(team.Key);
    Console.WriteLine($"{team.Key}");
    Console.WriteLine($"- {team.Value.Creator}");
    foreach (var member in team.Value.Members.OrderBy(t => t))
    {
        Console.WriteLine($"-- {member}");
    }
}

Console.WriteLine("Teams to disband:");
Console.WriteLine(string.Join(Environment.NewLine, disbands.OrderBy(t => t)));










