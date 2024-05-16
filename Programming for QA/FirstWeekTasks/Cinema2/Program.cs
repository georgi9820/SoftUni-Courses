string moveType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());

double price = 0;
double finalPrice = 0;
switch (moveType)
{
    case "Premiere":
        price += 12.00;
        finalPrice = (rows * seats) * price;
        Console.WriteLine($"{finalPrice:F2}");
        break;
    case "Normal":
        price += 7.50;
        finalPrice = (rows * seats) * price;
        Console.WriteLine($"{finalPrice:F2}");
        break;
    case "Discount":
        price += 5.00;
        finalPrice = (rows * seats) * price;
        Console.WriteLine($"{finalPrice:F2}");
        break;
}
