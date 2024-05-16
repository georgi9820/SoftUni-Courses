namespace Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            double waterPerMonth = 20;
            double internetPerMonth = 15;
            double electricityTotalPrice = 0;
            double totalWaterPrice = 0;
            double totalInternetPrice = 0;
            double othersPerMonth = 0;
            double totalSumOthers = 0;
            for (int i = 1; i <= month; i++)
            {
                double electricityPerMonth = double.Parse(Console.ReadLine());

                electricityTotalPrice += electricityPerMonth;
                totalWaterPrice += waterPerMonth;
                totalInternetPrice += internetPerMonth;
                //totalSumPerMonth = electricityPerMonth + waterPerMonth + internetPerMonth;
                othersPerMonth = (electricityPerMonth + waterPerMonth + internetPerMonth) * 1.2; 
                totalSumOthers += othersPerMonth;
            }

            double averageSumPerMonth = (electricityTotalPrice + totalWaterPrice + totalInternetPrice + totalSumOthers) / month;

            Console.WriteLine($"Electricity: {electricityTotalPrice:F2} lv");
            Console.WriteLine($"Water: {totalWaterPrice:F2} lv");
            Console.WriteLine($"Internet: {totalInternetPrice:F2} lv");
            Console.WriteLine($"Other: {totalSumOthers:F2} lv");
            Console.WriteLine($"Average: {averageSumPerMonth:F2} lv");
        }
    }
}