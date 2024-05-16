string firstInput = Console.ReadLine();
string secondInput = Console.ReadLine();

string[] arr1 = firstInput.Split(" ");
string[] arr2 = secondInput.Split(" ");

GetComparisonOfArrays(arr1, arr2);

static void GetComparisonOfArrays(string[] arr1, string[] arr2)
{
    foreach (string str in arr2)
    {
        if (arr1.Contains(str))
        {
            Console.Write(str + " ");
        }
    }
}
