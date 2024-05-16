List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

while (numbers.Count > 1)
{
    List<int> output = new List<int>();
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        output.Add(numbers[i] + numbers[i + 1]);
    }
    numbers = output;
}

Console.WriteLine(numbers[0]);

//ВТОРО РЕШЕНИЕ С МАСИВ
//int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

//while (numbers.Length > 1)
//{
//    int[] condensedArray = new int[numbers.Length - 1];
//    for (int i = 0; i < numbers.Length - 1; i++)
//    {
//        condensedArray[i] = numbers[i] + numbers[i + 1];
//    }
//    numbers = condensedArray;
//}

//string result = string.Join(" ", numbers);
//Console.WriteLine(result);
