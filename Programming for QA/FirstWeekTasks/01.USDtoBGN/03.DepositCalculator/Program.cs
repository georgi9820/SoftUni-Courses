namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double amount = depositedAmount + termOfDeposit * (depositedAmount * (annualInterestRate / 100)) / 12;
            Console.WriteLine(amount);
        }
    }
}