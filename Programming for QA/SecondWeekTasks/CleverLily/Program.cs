namespace CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());
            int toyCounter = 0;
            int sum = 0;
            int money = 0;
            int yearEvenCounter = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    sum += money;
                    yearEvenCounter++;
                }
                else 
                {
                    toyCounter++;
                }
            }

            int moneyTakenFromBrother = yearEvenCounter * 1;
            int totalSumOfToySold = toyCounter * pricePerToy;
            int totalSavedMoney = (sum + totalSumOfToySold) - moneyTakenFromBrother;

            if (totalSavedMoney >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {(double)totalSavedMoney - priceWashingMachine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashingMachine - totalSavedMoney:F2}");
            }




        }
    }
}