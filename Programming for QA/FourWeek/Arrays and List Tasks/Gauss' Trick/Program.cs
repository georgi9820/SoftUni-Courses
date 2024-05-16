List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
PrintSumOfAllNumbers(input);

static void PrintSumOfAllNumbers(List<int> input)
{
    List<int> sums = new List<int>();
    int n = input.Count;

    for (int i = 0; i < n / 2; i++)
    {
        sums.Add(input[i] + input[n - i - 1]);
    }

    if (n % 2 == 1)
    {
        int num = input[input.Count / 2];
        sums.Add(num);
    }

    Console.WriteLine(string.Join(" ", sums));
}


