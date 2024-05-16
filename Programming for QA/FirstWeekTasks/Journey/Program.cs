namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double cost = 0;
            string holidayType = "";
            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        cost = budget * 0.30;
                    }
                    else if (budget <= 1000)
                    {
                        destination = "Balkans";
                        cost = budget * 0.40;
                    }
                    else if (budget > 1000)
                    {
                        destination = "Europe";
                        cost = budget * 0.90;
                    }
                    break;
                case "winter":
                    if(budget <= 100)
                    {
                        destination = "Bulgaria";
                        cost = budget * 0.70;
                    }
                    else if (budget <= 1000)
                    {
                        destination = "Balkans";
                        cost = budget * 0.80;
                    }
                    else if (budget > 1000)
                    {
                        destination = "Europe";
                        cost = budget * 0.90;
                    }
                    break;
            }

            if (season == "summer" && destination != "Europe")
            {
                holidayType = "Camp";
            }
            else
            {
                holidayType = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {cost:F2}");
        }
    }
}