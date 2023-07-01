using System;
using System.Threading;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = 7.61;
            double sum = area * pricePerSquareMeter;
            double discount = sum * 0.18;
            double finalPrice = sum - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
