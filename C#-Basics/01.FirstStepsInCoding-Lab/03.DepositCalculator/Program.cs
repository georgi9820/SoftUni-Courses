using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double annualInterest = double.Parse(Console.ReadLine());
            double interest = deposit * (annualInterest / 100);
            double mountInterest = interest / 12;
            double finalSum = deposit + term * mountInterest;
            Console.WriteLine(finalSum);
        }
    }
}
