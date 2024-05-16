int n = int.Parse(Console.ReadLine());

var continents = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] inputArr = input.Split(" ");
    string continent = inputArr[0];
    string country = inputArr[1];
    string city = inputArr[2];

    if (!continents.ContainsKey(continent))
    {
        continents.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!continents[continent].ContainsKey(country))
    {
        continents[continent].Add(country, new List<string>());
    }

    continents[continent][country].Add(city);
}

foreach (var continent in continents) // var -> KeyValuePair<string, Dictionary<string, List<string>>>
{
    Console.WriteLine($"{continent.Key}:");
    foreach (var country in continent.Value)
    {
        Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
    }
}  
