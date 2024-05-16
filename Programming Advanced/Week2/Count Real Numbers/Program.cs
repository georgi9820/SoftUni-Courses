int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

SortedDictionary<int, int> numberFrequency = new();

foreach (int number in numbers)
{
    if (numberFrequency.ContainsKey(number))
    {
        numberFrequency[number]++;
    }
    else
    {
        numberFrequency.Add(number, 1);
    }
}

foreach (KeyValuePair<int, int> pair in numberFrequency)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
