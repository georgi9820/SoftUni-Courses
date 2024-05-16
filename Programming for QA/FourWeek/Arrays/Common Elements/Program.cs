using System;

string firstInput = Console.ReadLine();
string secondInput = Console.ReadLine();

string[] firstItems = firstInput.Split(" ");
string[] secondItems = secondInput.Split(" ");

int[] arr1 = firstItems.Select(int.Parse).ToArray();
int[] arr2 = secondItems.Select(int.Parse).ToArray();

if (EqualLengthArrays(arr1,arr2))
{
    GetCommonElements(arr1, arr2);
}
static bool EqualLengthArrays(int[] arr1, int[] arr2)
{
    if (arr1.Length != arr2.Length)
    {
        return false;
    }
 
    return true;  
}

static void GetCommonElements(int[] array1, int[] array2)
{
    foreach (int item in array1)
    {
        if (array2.Contains(item))
        {
            Console.Write(item + " ");
        }
    }
}
