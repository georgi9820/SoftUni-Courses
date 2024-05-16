string text = Console.ReadLine().ToLower();

Console.WriteLine(CountOfVowels(text));

static int CountOfVowels(string text)
{
    int counter = 0;
    for (int i = 0; i < text.Length; i++)
    {
        switch (text[i])
        {
            case 'a':
                counter++;
                break;
            case 'e':
                counter++;
                break;
            case 'i':
                counter++;
                break;
            case 'o':
                counter++;
                break;
            case 'u':
                counter++;
                break;
        }
    }

    return counter;
}