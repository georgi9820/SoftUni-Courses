int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int countNegative = 0;

if (num1 == 0 || num2 == 0 || num3 == 0)
{
    Console.WriteLine("zero");
}
else
{
    if (num1 < 0)
    {
        countNegative++;
    }
    if (num2 < 0)
    {
        countNegative++;
    }
    if (num3 < 0)
    {
        countNegative++;
    }

    if (countNegative % 2 == 0)
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("negative");
    }
}

