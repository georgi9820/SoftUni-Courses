double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

var numberFrequency = new Dictionary<double, int>();

foreach (double number in numbers)
{
    if (!numberFrequency.ContainsKey(number))
    {
        numberFrequency.Add(number, 1);
    }
    else
    {
        numberFrequency[number]++;
    }
}

foreach (KeyValuePair<double, int> pair in numberFrequency)
{
    Console.WriteLine($"{pair.Key} - {pair.Value} times");
}
