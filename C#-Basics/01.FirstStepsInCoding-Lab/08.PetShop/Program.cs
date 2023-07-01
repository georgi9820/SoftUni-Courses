using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPackagesDogFood = int.Parse(Console.ReadLine());
            int numOfPackagesCatFood = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.50;
            int catFoodPrice = 4;

            double sum = (numOfPackagesCatFood * catFoodPrice) + (numOfPackagesDogFood * dogFoodPrice);

            Console.WriteLine($"{sum} lv.");
        }
    }
}
