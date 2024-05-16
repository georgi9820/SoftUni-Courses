string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
double totalPrice = TotalPrice(product, quantity);
Console.WriteLine($"{totalPrice:F2}");
static double TotalPrice(string product, int quantity)
{
    double sum = 0;
    switch (product)
    {
        case "coffee":
            sum = quantity * 1.50;
            break;
        case "water":
            sum = quantity * 1.00;
            break;
        case "coke":
            sum = quantity * 1.40;
            break;
        case "snacks":
            sum = quantity * 2.00;
            break;
    }
    return sum;
}
