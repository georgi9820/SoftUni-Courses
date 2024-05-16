List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int startIndex = numbers[0];
    numbers.Remove(numbers[0]);
    numbers.Add(startIndex);
}

Console.WriteLine(string.Join(" ", numbers));
