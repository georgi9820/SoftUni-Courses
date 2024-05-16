using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int firstDigit = 1; firstDigit <= n; firstDigit++)
        {
            for (int secondDigit = 1; secondDigit <= n; secondDigit++)
            {
                for (char firstLetter = 'a'; firstLetter < 'a' + l; firstLetter++)
                {
                    for (char secondLetter = 'a'; secondLetter < 'a' + l; secondLetter++)
                    {
                        for (int thirdDigit = 1; thirdDigit <= n; thirdDigit++)
                        {
                            if (thirdDigit > firstDigit && thirdDigit > secondDigit)
                            {
                                Console.Write($"{firstDigit}{secondDigit}{firstLetter}{secondLetter}{thirdDigit} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

//Math.Max(firstDigit, secondDigit) + 1