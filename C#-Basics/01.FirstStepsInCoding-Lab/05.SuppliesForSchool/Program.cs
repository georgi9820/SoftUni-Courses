using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPencilPackages = int.Parse(Console.ReadLine());
            int numberMarkerPackages = int.Parse(Console.ReadLine());
            int preparationLitres = int.Parse(Console.ReadLine());

            double packagePencils = 5.80;
            double packageMarkes = 7.20;
            double preparationPrice = 1.20;

            double pricePencils = numberPencilPackages * packagePencils;
            double priceMarkers = numberMarkerPackages * packageMarkes;
            double pricePreparation = preparationLitres * preparationPrice;

            double sum = pricePencils + priceMarkers + pricePreparation;
            double finalSum = sum - (sum * 0.25);
            Console.WriteLine(finalSum);
        }
    }
}
