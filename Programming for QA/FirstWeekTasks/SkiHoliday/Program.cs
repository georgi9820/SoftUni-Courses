namespace SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            String typeOfRoom = Console.ReadLine();
            String assessment = Console.ReadLine();

            double price = 0;
            int nights = days - 1;
            double finalPrice = 0;
            switch (typeOfRoom)
            {
                case "room for one person":
                    price = 118.00;
                    finalPrice = price * nights;
                    break;
                case "apartment":
                    price = 155.00;
                    finalPrice = price * nights;
                    if (days < 10)
                    {
                        finalPrice *= 0.7;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        finalPrice *= 0.65;
                    }
                    else if (days > 15)
                    {
                        finalPrice *= 0.5;
                    }
                    break;
                case "president apartment":
                    price = 235.00;
                    finalPrice = price * nights;
                    if (days < 10)
                    {
                        finalPrice *= 0.9;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        finalPrice *= 0.85;
                    }
                    else if (days > 15)
                    {
                        finalPrice *= 0.8;
                    }
                    break;
            }


            if (assessment == "positive")
            {
                //finalPrice = finalPrice + finalPrice * 0.25;
                finalPrice *= 1.25;
            }
            else if (assessment == "negative")
            {
                //finalPrice = finalPrice - finalPrice * 0.1;
                finalPrice *= 0.90;
            }

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}