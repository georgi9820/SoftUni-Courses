namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            String season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            double rentalCost = 0;
            double sumLeft = 0;
            double neededMoney = 0;
            switch (season)
            {
                case "Spring":
                    rentalCost = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    rentalCost = 4200;
                    break;
                case "Winter":
                    rentalCost = 2600;
                    break;
            }

            if (fishermenCount <= 6) 
            {
                rentalCost = rentalCost * 0.9;
            }
            else if (fishermenCount >= 7 && fishermenCount <= 11)            
            {
                rentalCost *= 0.85;
            }
            else if(fishermenCount >= 12)
            {
                rentalCost *= 0.75;
            }

            if (fishermenCount % 2 == 0 && season != "Autumn") 
            {
                rentalCost *= 0.95;
            }

            if (budget >= rentalCost)
            {
                sumLeft = budget - rentalCost;
                Console.WriteLine($"Yes! You have {sumLeft:F2} leva left.");
            }
            else if (budget < rentalCost)
            {
                neededMoney = rentalCost - budget;
                Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
            }
            

        }
    }
}