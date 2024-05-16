namespace EqualPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int previousPairSum = 0;
            int maxDifference = 0;
            bool allPairsEqual = true;

            namespace EqualPairs
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int previousPairSum = 0;
                int maxDifference = 0;
                bool allPairsEqual = true;

                for (int i = 0; i < n; i++)
                {
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());

                    int currentPairSum = firstNumber + secondNumber;

                    if (i == 0)
                    {
                        previousPairSum = currentPairSum;
                    }
                    else if (previousPairSum != currentPairSum)
                    {
                        allPairsEqual = false;
                    }

                    int currentDifference = Math.Abs(currentPairSum - previousPairSum);
                    maxDifference = Math.Max(maxDifference, currentDifference);

                    previousPairSum = currentPairSum;
                }

                if (allPairsEqual)
                {
                    Console.WriteLine($"Yes, value={previousPairSum}");
                }
                else
                {
                    Console.WriteLine($"No, maxdiff={maxDifference}");
                }
            }
        }
    }

            if (allPairsEqual)
            {
                Console.WriteLine($"Yes, value={previousPairSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }
        }
    }
}