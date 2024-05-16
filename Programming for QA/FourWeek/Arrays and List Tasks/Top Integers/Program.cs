﻿List<int> numbers = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToList();

List<int> output  = new List<int>();

for (int i = 0; i < numbers.Count; i++)
{
    bool isTopInteger = true;
    for (int j = i + 1; j < numbers.Count; j++)
    {
        if (numbers[i] <= numbers[j])
        {
            isTopInteger = false;
            break;
        }
    }

    if (isTopInteger)
    {
        output.Add(numbers[i]);
    }
}


Console.WriteLine(string.Join(" ", output));