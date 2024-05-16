using System.Security.Principal;

int size = int.Parse(Console.ReadLine());

for (int starCount = 1; starCount <= size; starCount++)
{
    for (int i = 0; i < size - starCount; i++)
    {
        Console.Write(" ");
    }
    for (int i = 0; i < starCount - 1; i++)
    {
        Console.Write("* ");
    }

    Console.WriteLine("*");
}

for (int starCount = size - 1; starCount > 0; starCount--)
{
    for (int i = 0; i < size - starCount; i++)
    {
        Console.Write(" ");
    }
    for (int i = 0; i < starCount - 1; i++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("*");
}
