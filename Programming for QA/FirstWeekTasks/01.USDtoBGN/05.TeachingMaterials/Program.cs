namespace _05.TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packageOfPens = 5.80;
            double packageOfMarkers = 7.20;
            double boardCleaner = 1.20;

            int numberOfPackagesOfPens = int.Parse(Console.ReadLine());
            int numberOfPackagesOfMarkers = int.Parse(Console.ReadLine());
            int litersOfBoardCleaner = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());

            double priceOfPackagesOfPens = numberOfPackagesOfPens * packageOfPens;
            double priceOfPackagesOfMarkers = numberOfPackagesOfMarkers * packageOfMarkers;
            double priceOfBoardCleaner = litersOfBoardCleaner * boardCleaner;
            double priceOfAllMaterials = priceOfPackagesOfPens + priceOfBoardCleaner + priceOfPackagesOfMarkers;
            double discount = discountPercentage / 100.0;
            double finalPrice = priceOfAllMaterials - (priceOfAllMaterials * discount);

            Console.WriteLine(finalPrice);
        }
    }
}