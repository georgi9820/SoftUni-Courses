namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegetarianMenu = 8.15;
            double delivery = 2.50;

            int numberOfChickenMenus = int.Parse(Console.ReadLine());
            int numberOfFishMenus = int.Parse(Console.ReadLine());
            int numberOfVegetarianMenus = int.Parse(Console.ReadLine());

            double priceForChickenMenu = numberOfChickenMenus * chickenMenu;
            double priceForFishMenu = numberOfFishMenus * fishMenu;
            double priceForVegetarianMenu = numberOfVegetarianMenus * vegetarianMenu;
            double totalCostOfMenus = priceForChickenMenu + priceForFishMenu + priceForVegetarianMenu;
            double priceForDessert = totalCostOfMenus * 0.20;
            double totalOrderPrice = totalCostOfMenus + priceForDessert + delivery;
            Console.WriteLine(totalOrderPrice);
        }
    }
}