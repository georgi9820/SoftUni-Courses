namespace _06.Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double protectiveNylon = 1.50;
            double paint = 14.50;
            double paintThinner = 5.00;
            double amountOfBags = 0.40;

            int requiredAmountOfNylon = int.Parse(Console.ReadLine());
            int requiredAmountOfPaint = int.Parse(Console.ReadLine());
            int quantityOfThinner = int.Parse(Console.ReadLine());
            int hoursNeededForCraftsmenToDoWork = int.Parse(Console.ReadLine());

            double nylonAmount = (requiredAmountOfNylon + 2) * protectiveNylon;
            double amountForPaint = (requiredAmountOfPaint + (requiredAmountOfPaint * 0.10)) * paint;
            double amountForThinner = (quantityOfThinner * paintThinner);
            double totalAmountOfMaterials = nylonAmount + amountForPaint + amountForThinner + amountOfBags;
            double amountForCraftsmen = (totalAmountOfMaterials * 0.30) * hoursNeededForCraftsmenToDoWork;
            double totalAmount = totalAmountOfMaterials + amountForCraftsmen;

            Console.WriteLine(totalAmount);
        }
    }
}