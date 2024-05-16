int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for (int i = 1; i <= max1; i++)
{
    for (int j = 1; j <= max2; j++)
    {
        int divisor = 0;
        for (int d = 1; d <= j; d++)
        {
            if (j % d == 0)
            {
                divisor++;
            }
        }

        if (divisor == 2)
        {
            for (int k = 1; k <= max3; k++)
            {
                if ((i % 2 == 0) && (k % 2 == 0))
                {
                    Console.WriteLine($"{i}{j}{k}");
                }
            }
        }
        
    }
}
