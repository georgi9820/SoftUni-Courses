namespace Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCargos = int.Parse(Console.ReadLine());

            int microbusCounter = 0;
            int truckCounter = 0;
            int trainCounter = 0;

            int totalCargosWeight = 0;
            double averageWeight = 0.00;

            for (int i = 1; i <= numberOfCargos; i++)
            {
                int cargoWeight = int.Parse(Console.ReadLine());

                if (cargoWeight <= 3)
                {
                    microbusCounter += cargoWeight;
                    totalCargosWeight += cargoWeight;
                }
                else if (cargoWeight <= 11)
                {
                    truckCounter += cargoWeight;
                    totalCargosWeight += cargoWeight;
                }
                else 
                {
                    trainCounter += cargoWeight;
                    totalCargosWeight += cargoWeight;
                }
                
            }

            averageWeight = (microbusCounter * 200.00 + truckCounter * 175.00 + trainCounter * 120.00) / totalCargosWeight;

            Console.WriteLine($"{averageWeight:f2}");
            Console.WriteLine($"{microbusCounter * 100.00 / totalCargosWeight:F2}%");
            Console.WriteLine($"{truckCounter * 100.00 / totalCargosWeight:F2}%");
            Console.WriteLine($"{trainCounter * 100.00 / totalCargosWeight:F2}%");


        }
    }
}