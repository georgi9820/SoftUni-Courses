namespace VacationSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int counterSpend = 0;

            while (availableMoney < moneyNeeded)
            {
                string command = Console.ReadLine();
                double money = int.Parse(Console.ReadLine());

                daysCounter++;
                if (command == "spend")
                {
                    counterSpend++;
                    if (counterSpend == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(daysCounter);
                        break;
                    }

                    availableMoney -= money;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    
                }
                else 
                {
                    availableMoney += money;
                    counterSpend = 0;
                }
                

            }
            if (availableMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }

        }
    }
}