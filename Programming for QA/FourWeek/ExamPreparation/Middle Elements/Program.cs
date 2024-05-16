int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

if (numbers.Length % 2 != 0)
{
    Console.WriteLine("The array length should be an even number.");
    return;
}

int middle = numbers.Length / 2;
double sum = 0;

for (int i = middle - 1; i <= middle; i++)
{
    sum += numbers[i];
}

double average = sum / 2;

Console.WriteLine($"Average of the middle elements: {average:F2}");
