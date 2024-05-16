int n = int.Parse(Console.ReadLine());


for (int j = 0; j < 2 * n; j++)
{
    Console.Write("*");
}

for (int j = 0; j < n; j++)
{
    Console.Write(" ");
}
for (int j = 0; j < 2 * n; j++)
{
    Console.Write("*");
}
Console.WriteLine();

for (int i = 0; i < n - 2; i++)
{
    Console.Write("*");
    for (int j = 0; j < 2 * n - 2; j++) 
    {
        Console.Write("/");
    }

    Console.Write("*");

    if (i == (n - 1) / 2 - 1)
    {
        for (int j = 0;j < n; j++)
        {
            Console.Write("|");
        }
    }
    else
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(" ");
        }
    }

    Console.Write("*");
    for (int j = 0; j < 2 * n - 2; j++)
    {
        Console.Write("/");
    }
    Console.Write("*");
    Console.WriteLine();
}


for (int j = 0; j < 2 * n; j++)
{
    Console.Write("*");
}

for (int j = 0; j < n; j++)
{
    Console.Write(" ");
}
for (int j = 0; j < 2 * n; j++)
{
    Console.Write("*");
}


