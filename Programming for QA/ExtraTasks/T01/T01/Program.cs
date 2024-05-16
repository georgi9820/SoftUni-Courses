namespace T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double rosesPrice = 5.00;
            double dahliasPrice = 3.80;
            double tulipsPrice = 2.80;
            double narcissusPrice = 3.00;
            double gladiolusPrice = 2.50;
            double discount = 0.00;
            double totalPrice = 0.00;
            double finalPrice = 0.00;
            double increase = 0.00;

            if (typeOfFlowers == "Roses")
            {
                if (countOfFlowers > 80)
                {
                    totalPrice = countOfFlowers * rosesPrice;
                    discount = 0.10 * totalPrice;
                    finalPrice = totalPrice - discount;
                }
                else
                {
                    totalPrice = countOfFlowers * rosesPrice;
                    finalPrice = totalPrice;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (countOfFlowers > 90)
                {
                    totalPrice = countOfFlowers * dahliasPrice;
                    discount = 0.15 * totalPrice;
                    finalPrice = totalPrice - discount;
                }
                else
                {
                    totalPrice = countOfFlowers * dahliasPrice;
                    finalPrice = totalPrice;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (countOfFlowers > 80)
                {
                    totalPrice = countOfFlowers * tulipsPrice;
                    discount = 0.15 * totalPrice;
                    finalPrice = totalPrice - discount;
                }
                else
                {
                    totalPrice = countOfFlowers * tulipsPrice;
                    finalPrice = totalPrice;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (countOfFlowers < 120)
                {
                    totalPrice = countOfFlowers * narcissusPrice;
                    increase = 0.15 * totalPrice;
                    finalPrice = totalPrice + increase;
                }
                else
                {
                    totalPrice = countOfFlowers * narcissusPrice;
                    finalPrice = totalPrice;
                }
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                if (countOfFlowers < 80)
                {
                    totalPrice = countOfFlowers * gladiolusPrice;
                    increase = 0.20 * totalPrice;
                    finalPrice = totalPrice + increase;
                }
                else
                {
                    totalPrice = countOfFlowers * gladiolusPrice;
                    finalPrice = totalPrice;
                }
            }


            if (budget > finalPrice)
            {
                double sumLeft = budget - finalPrice;
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {sumLeft:F2} leva left.");
            }
            else if (budget < finalPrice)
            {
                double neededMoney = finalPrice - budget;
                Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
            }
        }
    }
}