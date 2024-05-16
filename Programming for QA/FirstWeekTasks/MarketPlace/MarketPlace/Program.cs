string product = Console.ReadLine();
string day = Console.ReadLine();

double price = 0;

if (product == "Banana")
{
    switch (day)
    {
        case "Weekday":
            price += 2.50;
            Console.WriteLine($"{price:F2}");
            break;
        case "Weekend":
            price += 2.70;
            Console.WriteLine($"{price:F2}");
            break;
    }
}
else if (product == "Apple")
{
    if (day == "Weekday")
    {
        price += 1.30;
        Console.WriteLine($"{price:F2}");
    }
    else
    {
        price += 1.60;
        Console.WriteLine($"{price:F2}");
    }
}
else if (product == "Kiwi")
{
    if (day == "Weekday")
    {
        price += 2.20;
        Console.WriteLine($"{price:F2}");
    }
    else
    {
        price += 3.00;
        Console.WriteLine($"{price:F2}");
    }
}
