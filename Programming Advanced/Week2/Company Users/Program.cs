string input = Console.ReadLine();

var companies = new Dictionary<string, List<string>>();

while (input != "End")
{
    string[] inputArr = input.Split(" -> ");
    string companyName = inputArr[0];
    string employeeId = inputArr[1];

    if (!companies.ContainsKey(companyName))
    {
        companies.Add(companyName, new List<string>());
    }

    if (!companies[companyName].Contains(employeeId))
    {
        companies[companyName].Add(employeeId);
    }

    input = Console.ReadLine();
}

foreach (KeyValuePair<string, List<string>> currentCompany in companies)
{
    Console.WriteLine($"{currentCompany.Key}");

    foreach (string currentEmployeeId in currentCompany.Value)
    {
        Console.WriteLine($"-- {currentEmployeeId}");
    }
}
