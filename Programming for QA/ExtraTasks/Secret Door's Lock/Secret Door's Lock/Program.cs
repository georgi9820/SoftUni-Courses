int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());


for (int i = 1; i <= num1; i++)
{
    
    for (int j = 2; j <= num2; j++)
    {
        int divisors = 0;
        for (int d = 1; d <= j; d++)
        {
            if (j % d == 0)
            {
                divisors++;
            }
        }

        if (divisors == 2)
        {
            for (int k = 1; k <= num3; k++)
            {
                if (i % 2 == 0 && k % 2 == 0 && divisors == 2)
                {
                    Console.WriteLine($"{i} {j} {k}");
                }
            }
        }
        
    }
}
