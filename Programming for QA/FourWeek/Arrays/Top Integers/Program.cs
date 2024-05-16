using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        GetTopIntegers(arr);
    }

    static void GetTopIntegers(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            bool isTopInteger = true;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] <= arr[j])
                {
                    isTopInteger = false;
                    break;
                }
            }

            if (isTopInteger)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

