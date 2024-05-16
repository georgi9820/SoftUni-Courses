string input = Console.ReadLine();
double money = 0;
while (input != "End")
{
    double number = double.Parse(input);
    if (number >= 0)
    {
        money += number;
        Console.WriteLine($"Increase: {number:F2}");
    }
    else if (number < 0)
    {
        money -= number;
        Console.WriteLine($"Decrease: {Math.Abs(number):F2}");
    }
    input = Console.ReadLine();
}

Console.WriteLine($"Balance: {money:F2}");