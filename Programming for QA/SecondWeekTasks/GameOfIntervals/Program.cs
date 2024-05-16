using System.Diagnostics;

namespace GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMoves = int.Parse(Console.ReadLine());
            int counter = 0;
            int counterOne = 0;
            int counterTwo = 0;
            int counterThree = 0;
            int counterFour = 0;
            int counterFive = 0;
            double points = 0;

            for (int i = 1; i <= numberOfMoves; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0 || num > 50)
                {
                    points /= 2;
                    counter++;
                }
                else if (num >= 0 && num <= 9)
                {
                    points += num * 0.20;
                    counterOne++;
                }
                else if (num <= 19)
                {
                    points += num * 0.30;
                    counterTwo++;
                }
                else if (num <= 29)
                {
                    points += num * 0.40;
                    counterThree++;
                }
                else if (num <= 39)
                {
                    points += 50;
                    counterFour++;
                }
                else if (num <= 50)
                {
                    points += 100;
                    counterFive++;
                }
                
            }

            Console.WriteLine($"{points:F2}");
            Console.WriteLine($"From 0 to 9: {counterOne * 100.00 / numberOfMoves:F2}%");
            Console.WriteLine($"From 10 to 19: {counterTwo * 100.00 / numberOfMoves:F2}%");
            Console.WriteLine($"From 20 to 29: {counterThree * 100.00 / numberOfMoves:F2}%");
            Console.WriteLine($"From 30 to 39: {counterFour * 100.00 / numberOfMoves:F2}%");
            Console.WriteLine($"From 40 to 50: {counterFive * 100.00 / numberOfMoves:F2}%");
            Console.WriteLine($"Invalid numbers: {counter * 100.00 / numberOfMoves:F2}%");
        }
    }
}