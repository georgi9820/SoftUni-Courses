using System.Diagnostics.CodeAnalysis;

namespace TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            int g5 = 0;

            int num;

            int climberCount = 0;

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num <= 5)
                {
                    g1 += num;
                }
                else if (num >= 6 && num <= 12)
                {
                    g2 += num;
                }
                else if (num >= 13 && num <= 25)
                {
                    g3 += num;
                }
                else if (num >= 26 && num <= 40)
                {
                    g4 += num;
                }
                else
                {
                    g5 += num;
                }

                climberCount += num; 
            }
            Console.WriteLine($"{100.0 * g1 / climberCount:f2}%");
            Console.WriteLine($"{100.0 * g2 / climberCount:f2}%");
            Console.WriteLine($"{100.0 * g3 / climberCount:f2}%");
            Console.WriteLine($"{100.0 * g4 / climberCount:f2}%");
            Console.WriteLine($"{100.0 * g5 / climberCount:f2}%");
        }
    }
}