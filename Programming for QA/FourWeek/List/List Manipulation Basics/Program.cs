﻿List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Add"))
    {
        int numberToAdd = int.Parse(command.Split(" ")[1]);
        numbers.Add(numberToAdd);
    }
    else if (command.StartsWith("RemoveAt"))
    {
        int numberToRemoveAt = int.Parse(command.Split(" ")[1]);
        numbers.RemoveAt(numberToRemoveAt);
    }
    else if (command.StartsWith("Remove"))
    {
        int numberToRemove = int.Parse(command.Split(" ")[1]);
        numbers.Remove(numberToRemove);
    }
    else if (command.StartsWith("Insert"))
    {
        int numberToInsert = int.Parse(command.Split(" ")[1]);
        int position = int.Parse(command.Split(" ")[2]);
        numbers.Insert(position, numberToInsert);
    }


    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));