int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

int combinations = 0;
int sum = 0;

for (int i = start; i <= end; i++)
{
    for (int j = start; j <= end; j++)
    {
        combinations++;
        sum = i + j;
        if (sum == magicNumber)
        {
            Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
            return;
        }

    }
}

if (sum != magicNumber)
{
    Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
}
