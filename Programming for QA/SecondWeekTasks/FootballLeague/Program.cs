using System;

namespace FootballLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int totalFans = int.Parse(Console.ReadLine());
            int counterA = 0;
            int counterB = 0;
            int counterV = 0;
            int counterG = 0;
            for (int i = 1; i <= totalFans; i++)
            {
                string sector = Console.ReadLine();

                switch (sector) 
                {
                    case "A":
                        counterA++;
                        break;
                    case "B":
                        counterB++;
                        break;
                    case "V":
                        counterV++;
                        break;
                    case "G":
                        counterG++;
                        break;
                }
            }

            Console.WriteLine($"{counterA * 100.00 / totalFans:F2}%");
            Console.WriteLine($"{counterB * 100.00 / totalFans:F2}%");
            Console.WriteLine($"{counterV * 100.00 / totalFans:F2}%");
            Console.WriteLine($"{counterG * 100.00 / totalFans:F2}%");
            Console.WriteLine($"{totalFans * 100.00 / stadiumCapacity:F2}%");

        }
    }
}