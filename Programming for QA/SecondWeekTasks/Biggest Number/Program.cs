int n = int.Parse(Console.ReadLine());

int max = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int input = int.Parse(Console.ReadLine());

    if (input > max)
    {
        max = input;
    }
}

Console.WriteLine(max);

