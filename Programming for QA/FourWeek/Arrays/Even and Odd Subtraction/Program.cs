string values = Console.ReadLine();
int sumOfOdds = 0;
int sumOfEvens = 0;
string[] items = values.Split(" ");
int[] arr = items.Select(int.Parse).ToArray();

foreach (int item in arr)
{
    if (item % 2 != 0)
    {
        sumOfOdds += item;
    }
    else
    {
        sumOfEvens += item;
    }
}

Console.WriteLine(sumOfEvens - sumOfOdds);

