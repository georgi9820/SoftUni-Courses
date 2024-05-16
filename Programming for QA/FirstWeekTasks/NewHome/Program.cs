using System.Runtime.Intrinsics.X86;

namespace NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (typeOfFlowers == "Roses") 
            {
                price = 5;
            }
            else if (typeOfFlowers == "Dahlias")
            {
                price = 3.80;
            }
            else if (typeOfFlowers == "Tulips")
            {
                price = 2.80;
            }
            else if (typeOfFlowers == "Narcissus")
            {
                price = 3;
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                price = 2.50;
            }

            double totalCosts = price * countOfFlowers;

            if (typeOfFlowers == "Roses" && countOfFlowers > 80)
            {
                totalCosts = totalCosts - 0.10 * totalCosts;
            }
            else if ((typeOfFlowers == "Dahlias" && countOfFlowers > 90) || (typeOfFlowers == "Tulips" && countOfFlowers > 80))
            {
                totalCosts = totalCosts - 0.15 * totalCosts;
            }
            else if (typeOfFlowers == "Narcissus" && countOfFlowers < 120)
            {
                totalCosts = totalCosts + 0.15 * totalCosts;
            }
            else if (typeOfFlowers == "Gladiolus" && countOfFlowers < 80)
            {
                totalCosts = totalCosts + 0.20 * totalCosts;
            }

            if (budget >= totalCosts)
            {
                double sumLeft = budget - totalCosts;
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {sumLeft:F2} leva left.");
            }else if (budget < totalCosts)
            {
                double neededMoney = totalCosts - budget;
                Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
            }
        }
    }
}