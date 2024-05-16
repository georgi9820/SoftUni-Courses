List<string> shoppingList = Console.ReadLine().Split("!").ToList();

string command = Console.ReadLine();

while (command != "Go Shopping!")
{
    if (command.StartsWith("Urgent"))
    {
        string item = command.Split(" ")[1];
        if (!shoppingList.Contains(item))
        {
            shoppingList.Insert(0, item);
        }
    }
    else if (command.StartsWith("Unnecessary"))
    {
        string item = command.Split(" ")[1];
        if (shoppingList.Contains(item))
        {
            shoppingList.Remove(item);
        }
    }
    else if (command.StartsWith("Correct"))
    {
        string oldItem = command.Split(" ")[1];
        string newItem = command.Split(" ")[2];

        int index = shoppingList.IndexOf(oldItem);

        if (index >= 0)
        {
            shoppingList[index] = newItem;
        }
    }
    else if (command.StartsWith("Rearrange"))
    {
        string item = command.Split(" ")[1];
        int index = shoppingList.IndexOf(item);

        if (shoppingList.Contains(item))
        {
            
            shoppingList.RemoveAt(index);
            shoppingList.Add(item);
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(", ", shoppingList));


