var shops = new SortedDictionary<string, Dictionary<string, double>>();

string input = Console.ReadLine();

while (input != "Revision")
{
    string[] inputArr = input.Split(", ");
    string foodShop = inputArr[0];
    string product = inputArr[1];
    double price = double.Parse(inputArr[2]); // Закръгли цената до 1 десетична знак

    if (!shops.ContainsKey(foodShop))
    {
        shops.Add(foodShop, new Dictionary<string, double>());
    }

    shops[foodShop][product] = price;

    input = Console.ReadLine();
}

foreach (var shop in shops)
{
    Console.WriteLine($"{shop.Key}->");

    foreach (var productPricePair in shop.Value)
    {
        Console.WriteLine($"Product: {productPricePair.Key}, Price: {productPricePair.Value}");
    }
}