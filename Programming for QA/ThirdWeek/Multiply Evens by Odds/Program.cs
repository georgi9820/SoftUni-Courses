int number = Math.Abs(int.Parse(Console.ReadLine()));

static int GetSumOfEvenDigits(int number)
{
    int sumOfEven = 0;
    int digit = 0;
    string text = number.ToString();
    for (int i = 0; i < text.Length; i++)
    {
        digit = int.Parse(text[i].ToString());
        if (digit % 2 == 0)
        {
            sumOfEven += digit;
        }
    }

    return sumOfEven;
}

static int GetSumOfOddDigits(int number)
{
    int sumOfOdds = 0;
    int digit = 0;
    string text = number.ToString();
    for (int i = 0; i < text.Length; i++)
    {
        digit = int.Parse(text[i].ToString());
        if (digit % 2 != 0)
        {
            sumOfOdds += digit;
        }
    }

    return sumOfOdds;
}

static int GetMultipleOfEvenAndOdds(int number)
{
    return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
}

Console.WriteLine(GetMultipleOfEvenAndOdds(number));
