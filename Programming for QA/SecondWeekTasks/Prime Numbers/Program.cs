int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    int divisor = 0;

    for (int d = 1; d <= i; d++)
    {
        if (i % d == 0)
        {
            divisor++;
        }
    }

    if (divisor == 2)
    {
        Console.Write(i + " ");
    }
}
