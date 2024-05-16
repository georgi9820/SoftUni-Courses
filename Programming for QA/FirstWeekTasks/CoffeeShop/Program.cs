namespace CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string extra = Console.ReadLine();

            double price = 0;
            switch (drink)
            {
                case "coffee":
                    if (extra == "sugar")
                    {
                        price += 1.40;
                        Console.WriteLine($"Final price: ${price:f2}");
                    }
                    else if (extra == "no")
                    {
                        price += 1.00;
                        Console.WriteLine($"Final price: ${price:f2}");
                    }
                    break;
                case "tea":
                    if (extra == "sugar")
                    {
                        price += 1.00;
                        Console.WriteLine($"Final price: ${price:f2}");
                    }
                    else if (extra == "no")
                    {
                        price += 0.60;
                        Console.WriteLine($"Final price: ${price:f2}");
                    }
                    break;
            }
        }
    }
}