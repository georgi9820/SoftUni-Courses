using System;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int result = FindEqualSumsIndex(array);

        if (result != -1)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("no");
        }
    }

    static int FindEqualSumsIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            // Сума на елементите вляво от текущия индекс
            for (int j = 0; j < i; j++)
            {
                leftSum += arr[j];
            }

            // Сума на елементите вдясно от текущия индекс
            for (int k = i + 1; k < arr.Length; k++)
            {
                rightSum += arr[k];
            }

            if (leftSum == rightSum)
            {
                return i;
            }
        }

        return -1; // Ако няма такъв елемент
    }
}

