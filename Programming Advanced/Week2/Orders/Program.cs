using System.Resources;

var orders = new Dictionary<string, List<decimal>>();

string input = Console.ReadLine();

while (input != "buy")
{
    string[] products = input.Split(" ");
    string productName = products[0];
    decimal price = decimal.Parse(products[1]);
    decimal quantity = decimal.Parse(products[2]);

    if (!orders.ContainsKey(productName))
    {
        orders.Add(productName, new List<decimal>());
        orders[productName].Add(price);
        orders[productName].Add(quantity);

    }
    else
    {
        orders[productName][0] = price;
        orders[productName][1] += quantity;
    }

    input = Console.ReadLine();
}

foreach (KeyValuePair<string, List<decimal>> order in orders)
{
    string productName = order.Key;
    decimal currentProductPrice = order.Value[0];
    decimal currentProductQuantity = order.Value[1];

    decimal currentProductAmount = currentProductPrice * currentProductQuantity;


    Console.WriteLine($"{productName} -> {currentProductAmount:F2}");
}
