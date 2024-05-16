List<int> firstInput = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> secondInput = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> output = new List<int>();
int maxLenght = Math.Max(firstInput.Count, secondInput.Count);

for (int i = 0; i < maxLenght; i++)
{
    if (i < firstInput.Count)
    {
        output.Add(firstInput[i]);
    }

    if (i < secondInput.Count)
    {
        output.Add(secondInput[i]);
    }
}

Console.WriteLine(string.Join(" ", output));









//List<int> firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
//List<int> secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

//SetMergedList(firstArray, secondArray);

//static void SetMergedList(List<int> firstArray, List<int> secondArray)
//{
//    List<int> merged = new List<int>();
//    int longerCount = Math.Max(firstArray.Count, secondArray.Count);

//    for (int i = 0; i < longerCount; i++)
//    {
//        if (i < firstArray.Count)
//        {
//            merged.Add(firstArray[i]);
//        }

//        if (i < secondArray.Count)
//        {
//            merged.Add(secondArray[i]);
//        }
//    }
//    Console.WriteLine(string.Join(" ", merged));
//}

