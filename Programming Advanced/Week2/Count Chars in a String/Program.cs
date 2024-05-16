string text = Console.ReadLine();

var letterFrequency = new Dictionary<char, int>();

foreach (char letter in text)
{
    if (letter == ' ')
    {
        continue;
    }

    if (!letterFrequency.ContainsKey(letter))
    {
        letterFrequency.Add(letter, 1);
    }
    else
    {
        letterFrequency[letter]++;
    }
}

foreach (KeyValuePair<char, int> pair in letterFrequency)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}



