namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualBasketballTrainingFee = int.Parse(Console.ReadLine());

            double sneakersPrice = annualBasketballTrainingFee - (annualBasketballTrainingFee * 0.40);
            double basketballTeamPrice = sneakersPrice - (sneakersPrice * 0.20);
            double basketballPrice = basketballTeamPrice * 0.25;
            double basketballAccessoriesPrice = basketballPrice * 0.20;
            double totalPriceOfEquipment = annualBasketballTrainingFee + sneakersPrice + basketballPrice + basketballTeamPrice + basketballAccessoriesPrice;
            Console.WriteLine(totalPriceOfEquipment);
        }
    }
}