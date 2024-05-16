using System;

class Program
{
    static void Main()
    {
        int count1lv = int.Parse(Console.ReadLine());
        int count2lv = int.Parse(Console.ReadLine());
        int count5lv = int.Parse(Console.ReadLine());
        int targetSum = int.Parse(Console.ReadLine());

        for (int oneLvCount = 0; oneLvCount <= count1lv; oneLvCount++)
        {
            for (int twoLvCount = 0; twoLvCount <= count2lv; twoLvCount++)
            {
                for (int fiveLvCount = 0; fiveLvCount <= count5lv; fiveLvCount++)
                {
                    int currentSum = oneLvCount + (twoLvCount * 2) + (fiveLvCount * 5);

                    if (currentSum == targetSum)
                    {
                        Console.WriteLine($"{oneLvCount} * 1 lv. + {twoLvCount} * 2 lv. + {fiveLvCount} * 5 lv. = {targetSum} lv.");
                    }
                }
            }
        }
    }
}

