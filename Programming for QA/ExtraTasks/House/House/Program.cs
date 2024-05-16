int n = int.Parse(Console.ReadLine());

for (int row = 0; row < (n + 1) / 2; row++)
{
    if (n % 2 == 0)
    {
        Console.WriteLine("*");
    }
    else
    {
        Console.WriteLine("**");
    }
}
