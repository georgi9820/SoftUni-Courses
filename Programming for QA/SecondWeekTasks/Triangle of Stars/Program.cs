int n = int.Parse(Console.ReadLine());

for (int row = 1; row <= n; row++)
{
    for (int col = row; col >= 1; col--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
