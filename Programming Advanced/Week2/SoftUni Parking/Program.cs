var registars = new Dictionary<string, string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] commandArray = Console.ReadLine().Split().ToArray();

    string command = commandArray[0];
    string username = commandArray[1];

    if (command == "register")
    {
        
        string licensePlateNumber = commandArray[2];
        if (!registars.ContainsKey(username))
        {
            registars.Add(username, licensePlateNumber);
            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {registars[username]}");
        }
    }
    else if (command == "unregister")
    {
        if (registars.ContainsKey(username))
        {
            registars.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
    }

}

foreach (KeyValuePair<string, string> pair in registars)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}
