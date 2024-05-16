﻿List<int> firstPlayer = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> secondPlayer = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
{
    if (firstPlayer[0] > secondPlayer[0])
    {
        firstPlayer.Add(secondPlayer[0]);
        firstPlayer.Add(firstPlayer[0]);
    }
    else if (secondPlayer[0] > firstPlayer[0])
    {
        secondPlayer.Add(firstPlayer[0]);
        secondPlayer.Add(secondPlayer[0]);
    }

    firstPlayer.RemoveAt(0);
    secondPlayer.RemoveAt(0);   
}

if (firstPlayer.Count > 0)
{
    int sum = firstPlayer.Sum();
    Console.WriteLine($"First player wins! Sum: {sum}");
}
else
{
    int sum = secondPlayer.Sum();
    Console.WriteLine($"Second player wins! Sum: {sum}");
}
