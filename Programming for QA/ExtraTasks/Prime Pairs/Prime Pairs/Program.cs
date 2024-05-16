int startFirstPair = int.Parse(Console.ReadLine());
int startSecondPair = int.Parse(Console.ReadLine());
int differenceFirstPair = int.Parse(Console.ReadLine());
int differenceSecondPair = int.Parse(Console.ReadLine());

int endFirstPair = startFirstPair + differenceFirstPair;
int endSecondPair = startSecondPair + differenceSecondPair;

for (int firstPair1 = startFirstPair; firstPair1 <= endFirstPair; firstPair1++)
{
    int divisors1 = 0;
    for (int d = 1; d <= firstPair1; d++)
    {
        if (firstPair1 % d == 0)
        {
            divisors1++;
        }
    }

    if (divisors1 == 2)
    {
        for (int secondPair1 = startSecondPair; secondPair1 <= endSecondPair; secondPair1++)
        {
            int divisors2 = 0;
            for (int d = 1; d <= secondPair1; d++)
            {
                if (secondPair1 % d == 0)
                {
                    divisors2++;
                }
            }

            if (divisors2 == 2)
            {
                Console.WriteLine($"{firstPair1}{secondPair1}");
            }
        }
    }
}
