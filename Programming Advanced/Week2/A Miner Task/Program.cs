Dictionary<string, int> resources = new Dictionary<string, int>();

string input = Console.ReadLine();

while (input != "stop")
{
    int quantity = int.Parse(Console.ReadLine());
    
    
    if (!resources.ContainsKey(input))
    {
        resources.Add(input, quantity);
    }
    else
    {
        resources[input] += quantity;
    }
    

    input = Console.ReadLine();
}

foreach (KeyValuePair<string, int> pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
