namespace TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            string input;
            int totalPoints = 0;
            int winsCounter = 0;
            int counterSF = 0;
            int counterF = 0;
            int counterW = 0;

            for (int i = 1; i <= n; i++)
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "F":
                        startPoints += 1200;
                        counterF += 1200;
                        break;
                    case "SF":
                        startPoints += 720;
                        counterSF += 720;
                        break;
                    case "W":
                        startPoints += 2000;
                        winsCounter++;
                        counterW += 2000;
                        break;
                }
            }

            int average = (counterF + counterW + counterSF) / n;
            double percentWinners = (winsCounter / (double)n) * 100;

            Console.WriteLine($"Final points: {startPoints}");
            Console.WriteLine($"Average points: {average}");
            Console.WriteLine($"{percentWinners:F2}%");
        }
    }
}