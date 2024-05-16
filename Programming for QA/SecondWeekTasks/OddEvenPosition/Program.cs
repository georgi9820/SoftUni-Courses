namespace OddEvenPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddMax = double.MinValue;
            double evenMax = double.MinValue;
            double oddMin = double.MaxValue;
            double evenMin = double.MaxValue;
            double oddSum = 0;
            double evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    evenSum += number;

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                else if (i % 2 == 1)
                {
                    oddSum += number;

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:F2},");
            Console.WriteLine(oddMin != double.MaxValue ? $"OddMin={oddMin:F2}," : "OddMin=No,");
            Console.WriteLine(oddMax != double.MinValue ? $"OddMax={oddMax:F2}," : "OddMax=No,");
            Console.WriteLine($"EvenSum={evenSum:F2},");
            Console.WriteLine(evenMin != double.MaxValue ? $"EvenMin={evenMin:F2}," : "EvenMin=No,");
            Console.WriteLine(evenMax != double.MinValue ? $"EvenMax={evenMax:F2}" : "EvenMax=No");
        }
    }
}